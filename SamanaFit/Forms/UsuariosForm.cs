using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SamanaFit.Data.Context;
using SamanaFit.Data.Models;

namespace SamanaFit.Ui.Forms
{
    public partial class UsuariosForm : Form
    {
        private readonly List<int> _idsSexos = new();
        private readonly List<int> _idsNiveles = new();
        private readonly List<int> _idsObjetivos = new();

        private bool _suspenderEventosSeleccion;

        public UsuariosForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarUsuariosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void ConfigurarFormulario()
        {
            dtpFechaRegistro.Value = DateTime.Today;
            CargarIdsCatalogos();

            if (cmbSexo.Items.Count > 0) cmbSexo.SelectedIndex = 0;
            if (cmbNivelFisico.Items.Count > 0) cmbNivelFisico.SelectedIndex = 0;
            if (cmbObjetivo.Items.Count > 0) cmbObjetivo.SelectedIndex = 0;

            dgvUsuarios.ClearSelection();
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;

            Shown += UsuariosForm_Shown;
        }

        private void UsuariosForm_Shown(object? sender, EventArgs e)
        {
            // Al mostrarse el formulario, WinForms puede volver a seleccionar la primera fila.
            // Forzamos el estado “nuevo registro” con los campos vacíos.
            LimpiarFormulario();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario(out var edad))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var idSexo = ObtenerIdSexoSeleccionado();
            var idNivel = ObtenerIdNivelSeleccionado();
            var idObjetivo = ObtenerIdObjetivoSeleccionado();
            if (!idSexo.HasValue || !idNivel.HasValue || !idObjetivo.HasValue)
            {
                MessageBox.Show("No se pudieron resolver Sexo, Nivel u Objetivo en base de datos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuario = new Usuario
            {
                Nombre = ConstruirNombreCompleto(),
                Edad = edad,
                Peso = ParseDecimalNullable(txtPeso.Text),
                Altura = ParseDecimalNullable(txtAltura.Text),
                IdSexo = idSexo.Value,
                IdNivel = idNivel.Value,
                IdObjetivo = idObjetivo.Value
            };

            context.Usuarios.Add(usuario);
            context.SaveChanges();

            CargarUsuariosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                MessageBox.Show("Selecciona un usuario para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idSeleccionado = ObtenerIdDesdeFila(fila);
            if (idSeleccionado is null)
            {
                MessageBox.Show("No se pudo identificar el usuario seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActualizarUsuarioEnBaseDatos(idSeleccionado.Value);
            CargarUsuariosDesdeBaseDatos();
            SeleccionarFilaPorId(idSeleccionado.Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Deseas eliminar el usuario seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            var idSeleccionado = ObtenerIdDesdeFila(fila);
            if (idSeleccionado is null)
            {
                MessageBox.Show("No se pudo identificar el usuario seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new SamanaFitContext())
            {
                var usuario = context.Usuarios.Find(idSeleccionado.Value);
                if (usuario is not null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            }

            CargarUsuariosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private void dgvUsuarios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private bool ValidarFormulario(out int edad)
        {
            edad = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y apellido son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtEdad.Text, out edad) || edad <= 0)
            {
                MessageBox.Show("La edad debe ser un número válido mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbSexo.SelectedIndex <= 0 || cmbNivelFisico.SelectedIndex <= 0 || cmbObjetivo.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona sexo, nivel y objetivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            _suspenderEventosSeleccion = true;
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
            if (cmbSexo.Items.Count > 0) cmbSexo.SelectedIndex = 0;
            if (cmbNivelFisico.Items.Count > 0) cmbNivelFisico.SelectedIndex = 0;
            if (cmbObjetivo.Items.Count > 0) cmbObjetivo.SelectedIndex = 0;
            dtpFechaRegistro.Value = DateTime.Today;
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
            txtNombre.Focus();
            _suspenderEventosSeleccion = false;
        }

        private DataGridViewRow? ObtenerFilaSeleccionada()
        {
            return dgvUsuarios.SelectedRows.Count > 0 ? dgvUsuarios.SelectedRows[0] : null;
        }

        private void CargarDatosFilaSeleccionada()
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                return;
            }

            var idSeleccionado = ObtenerIdDesdeFila(fila);
            if (idSeleccionado is null)
            {
                return;
            }

            using var context = new SamanaFitContext();
            var usuario = context.Usuarios.FirstOrDefault(u => u.IdUsuario == idSeleccionado.Value);
            if (usuario is null)
            {
                return;
            }

            SepararNombreCompleto(usuario.Nombre, out var nombre, out var apellido);
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = usuario.Edad?.ToString() ?? string.Empty;
            txtPeso.Text = usuario.Peso?.ToString() ?? string.Empty;
            txtAltura.Text = usuario.Altura?.ToString() ?? string.Empty;
            cmbSexo.SelectedIndex = ObtenerIndiceComboPorId(_idsSexos, usuario.IdSexo);
            cmbNivelFisico.SelectedIndex = ObtenerIndiceComboPorId(_idsNiveles, usuario.IdNivel);
            cmbObjetivo.SelectedIndex = ObtenerIndiceComboPorId(_idsObjetivos, usuario.IdObjetivo);
            dtpFechaRegistro.Value = DateTime.Today;
        }

        private void CargarUsuariosDesdeBaseDatos()
        {
            _suspenderEventosSeleccion = true;
            dgvUsuarios.Rows.Clear();

            using var context = new SamanaFitContext();
            var usuarios = context.Usuarios
                .OrderBy(u => u.IdUsuario)
                .ToList();

            foreach (var usuario in usuarios)
            {
                SepararNombreCompleto(usuario.Nombre, out var nombre, out var apellido);
                dgvUsuarios.Rows.Add(
                    usuario.IdUsuario.ToString("D3"),
                    nombre,
                    apellido,
                    (object?)usuario.Edad ?? DBNull.Value,
                    ObtenerTextoComboPorId(cmbSexo, _idsSexos, usuario.IdSexo),
                    ObtenerTextoComboPorId(cmbNivelFisico, _idsNiveles, usuario.IdNivel),
                    ObtenerTextoComboPorId(cmbObjetivo, _idsObjetivos, usuario.IdObjetivo));
            }

            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
            _suspenderEventosSeleccion = false;
        }

        private void SeleccionarFilaPorId(int id)
        {
            _suspenderEventosSeleccion = true;
            try
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    var rowId = ObtenerIdDesdeFila(row);
                    if (rowId == id)
                    {
                        row.Selected = true;
                        dgvUsuarios.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            finally
            {
                _suspenderEventosSeleccion = false;
            }

            CargarDatosFilaSeleccionada();
        }

        private int? ObtenerIdDesdeFila(DataGridViewRow fila)
        {
            var idTexto = fila.Cells["colId"].Value?.ToString();
            if (!int.TryParse(idTexto, out var id))
            {
                return null;
            }

            return id;
        }

        private void ActualizarUsuarioEnBaseDatos(int id)
        {
            using var context = new SamanaFitContext();
            var usuario = context.Usuarios.Find(id);
            if (usuario is null)
            {
                MessageBox.Show("El usuario no existe en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) || !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                usuario.Nombre = ConstruirNombreCompleto();
            }

            if (!string.IsNullOrWhiteSpace(txtEdad.Text) && int.TryParse(txtEdad.Text, out var edad) && edad > 0)
            {
                usuario.Edad = edad;
            }

            if (cmbNivelFisico.SelectedIndex > 0)
            {
                var idNivel = ObtenerIdNivelSeleccionado();
                if (idNivel.HasValue)
                {
                    usuario.IdNivel = idNivel.Value;
                }
            }

            if (cmbSexo.SelectedIndex > 0)
            {
                var idSexo = ObtenerIdSexoSeleccionado();
                if (idSexo.HasValue)
                {
                    usuario.IdSexo = idSexo.Value;
                }
            }

            if (cmbObjetivo.SelectedIndex > 0)
            {
                var idObjetivo = ObtenerIdObjetivoSeleccionado();
                if (idObjetivo.HasValue)
                {
                    usuario.IdObjetivo = idObjetivo.Value;
                }
            }

            var peso = ParseDecimalNullable(txtPeso.Text);
            if (peso.HasValue)
            {
                usuario.Peso = peso;
            }

            var altura = ParseDecimalNullable(txtAltura.Text);
            if (altura.HasValue)
            {
                usuario.Altura = altura;
            }

            context.SaveChanges();
        }

        private string ConstruirNombreCompleto()
        {
            var nombre = txtNombre.Text.Trim();
            var apellido = txtApellido.Text.Trim();
            return $"{nombre}|{apellido}";
        }

        private static void SepararNombreCompleto(string? nombreCompleto, out string nombre, out string apellido)
        {
            var valor = (nombreCompleto ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(valor))
            {
                nombre = string.Empty;
                apellido = string.Empty;
                return;
            }

            var separador = valor.IndexOf('|');
            if (separador >= 0)
            {
                nombre = valor[..separador].Trim();
                apellido = valor[(separador + 1)..].Trim();
                return;
            }

            var partes = valor.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
            nombre = partes[0];
            apellido = partes.Length > 1 ? partes[1] : string.Empty;
        }

        private static int ObtenerIndiceComboPorId(IReadOnlyList<int> ids, int? id)
        {
            if (!id.HasValue)
            {
                return 0;
            }

            for (var i = 0; i < ids.Count; i++)
            {
                if (ids[i] == id.Value)
                {
                    return i + 1;
                }
            }

            return 0;
        }

        private static string ObtenerTextoComboPorId(ComboBox comboBox, IReadOnlyList<int> ids, int? id)
        {
            var idx = ObtenerIndiceComboPorId(ids, id);
            return idx > 0 ? comboBox.Items[idx]?.ToString() ?? string.Empty : string.Empty;
        }

        private int? ObtenerIdNivelSeleccionado()
        {
            var idx = cmbNivelFisico.SelectedIndex - 1;
            if (idx < 0 || idx >= _idsNiveles.Count)
            {
                return null;
            }

            return _idsNiveles[idx];
        }

        private int? ObtenerIdSexoSeleccionado()
        {
            var idx = cmbSexo.SelectedIndex - 1;
            if (idx < 0 || idx >= _idsSexos.Count)
            {
                return null;
            }

            return _idsSexos[idx];
        }

        private int? ObtenerIdObjetivoSeleccionado()
        {
            var idx = cmbObjetivo.SelectedIndex - 1;
            if (idx < 0 || idx >= _idsObjetivos.Count)
            {
                return null;
            }

            return _idsObjetivos[idx];
        }

        private void CargarIdsCatalogos()
        {
            _idsSexos.Clear();
            _idsNiveles.Clear();
            _idsObjetivos.Clear();

            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Seleccione sexo");
            cmbNivelFisico.Items.Clear();
            cmbNivelFisico.Items.Add("Seleccione un nivel");
            cmbObjetivo.Items.Clear();
            cmbObjetivo.Items.Add("Seleccione un objetivo");

            using var context = new SamanaFitContext();

            var sexos = context.Sexos
                .OrderBy(s => s.IdSexo)
                .Select(s => new { s.IdSexo, s.Nombre })
                .ToList();

            var nombresSexoAgregados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var sexo in sexos)
            {
                var nombre = string.IsNullOrWhiteSpace(sexo.Nombre)
                    ? $"Sexo {sexo.IdSexo}"
                    : sexo.Nombre;

                if (!nombresSexoAgregados.Add(nombre))
                {
                    continue;
                }

                _idsSexos.Add(sexo.IdSexo);
                cmbSexo.Items.Add(nombre);
            }

            var niveles = context.Nivels
                .OrderBy(n => n.IdNivel)
                .Select(n => new { n.IdNivel, n.Descripcion })
                .ToList();

            var descripcionesNivelAgregadas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var nivel in niveles)
            {
                var descripcion = string.IsNullOrWhiteSpace(nivel.Descripcion)
                    ? $"Nivel {nivel.IdNivel}"
                    : nivel.Descripcion;

                if (!descripcionesNivelAgregadas.Add(descripcion))
                {
                    continue;
                }

                _idsNiveles.Add(nivel.IdNivel);
                cmbNivelFisico.Items.Add(descripcion);
            }

            var objetivos = context.Objetivos
                .OrderBy(o => o.IdObjetivo)
                .Select(o => new { o.IdObjetivo, o.Nombre })
                .ToList();

            var nombresObjetivoAgregados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var objetivo in objetivos)
            {
                var nombre = string.IsNullOrWhiteSpace(objetivo.Nombre)
                    ? $"Objetivo {objetivo.IdObjetivo}"
                    : objetivo.Nombre;

                if (!nombresObjetivoAgregados.Add(nombre))
                {
                    continue;
                }

                _idsObjetivos.Add(objetivo.IdObjetivo);
                cmbObjetivo.Items.Add(nombre);
            }
        }

        private decimal? ParseDecimalNullable(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return null;
            }

            return decimal.TryParse(valor, out var numero) ? numero : null;
        }
    }
}
