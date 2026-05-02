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
    public partial class EjerciciosForm : Form
    {
        private readonly List<int> _idsNiveles = new();
        private bool _suspenderEventosSeleccion;
        private int? _idEjercicioSeleccionado;

        public EjerciciosForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarEjerciciosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void ConfigurarFormulario()
        {
            CargarNivelesEnCombo();
            cmbNivelFisico.SelectedIndex = -1;
            cmbTipoEjercicio.SelectedIndex = -1;

            dgvEjercicios.SelectionChanged += dgvEjercicios_SelectionChanged;
            dgvEjercicios.CellClick += dgvEjercicios_CellClick;
            Shown += EjerciciosForm_Shown;
        }

        private void EjerciciosForm_Shown(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario(out var duracion, out var calorias))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var ejercicio = new Ejercicio
            {
                Nombre = txtNombreEjercicio.Text.Trim(),
                Tipo = cmbTipoEjercicio.SelectedItem?.ToString(),
                IdNivel = ObtenerIdNivelSeleccionado(),
                DuracionMinutos = duracion,
                CaloriasQuemadas = calorias,
                Descripcion = txtDescripcion.Text.Trim(),
                GrupoMuscular = string.Empty
            };

            context.Ejercicios.Add(ejercicio);
            context.SaveChanges();

            var idGuardado = ejercicio.IdEjercicio;
            CargarEjerciciosDesdeBaseDatos();
            SeleccionarFilaPorId(idGuardado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idEjercicioSeleccionado is null)
            {
                MessageBox.Show("Selecciona un ejercicio para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarFormulario(out var duracion, out var calorias))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var ejercicio = context.Ejercicios.FirstOrDefault(ej => ej.IdEjercicio == _idEjercicioSeleccionado.Value);
            if (ejercicio is null)
            {
                MessageBox.Show("No se encontró el ejercicio seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEjerciciosDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            ejercicio.Nombre = txtNombreEjercicio.Text.Trim();
            ejercicio.Tipo = cmbTipoEjercicio.SelectedItem?.ToString();
            ejercicio.IdNivel = ObtenerIdNivelSeleccionado();
            ejercicio.DuracionMinutos = duracion;
            ejercicio.CaloriasQuemadas = calorias;
            ejercicio.Descripcion = txtDescripcion.Text.Trim();
            ejercicio.GrupoMuscular = string.Empty;
            context.SaveChanges();

            var idEditado = ejercicio.IdEjercicio;
            CargarEjerciciosDesdeBaseDatos();
            SeleccionarFilaPorId(idEditado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idEjercicioSeleccionado is null)
            {
                MessageBox.Show("Selecciona un ejercicio para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Deseas eliminar el ejercicio seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            using var context = new SamanaFitContext();
            var ejercicio = context.Ejercicios.FirstOrDefault(ej => ej.IdEjercicio == _idEjercicioSeleccionado.Value);
            if (ejercicio is null)
            {
                MessageBox.Show("No se encontró el ejercicio seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarEjerciciosDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            context.Ejercicios.Remove(ejercicio);
            context.SaveChanges();

            CargarEjerciciosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvEjercicios_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private void dgvEjercicios_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private void CargarEjerciciosDesdeBaseDatos()
        {
            _suspenderEventosSeleccion = true;
            dgvEjercicios.Rows.Clear();

            using var context = new SamanaFitContext();
            var ejercicios = context.Ejercicios
                .OrderBy(e => e.IdEjercicio)
                .ToList();

            foreach (var ejercicio in ejercicios)
            {
                dgvEjercicios.Rows.Add(
                    ejercicio.IdEjercicio,
                    ejercicio.Nombre ?? string.Empty,
                    ejercicio.Tipo ?? string.Empty,
                    ObtenerTextoNivelPorId(ejercicio.IdNivel),
                    ejercicio.DuracionMinutos?.ToString() ?? string.Empty,
                    ejercicio.CaloriasQuemadas?.ToString() ?? string.Empty,
                    ejercicio.Descripcion ?? string.Empty);
            }

            dgvEjercicios.ClearSelection();
            dgvEjercicios.CurrentCell = null;
            _suspenderEventosSeleccion = false;
        }

        private void CargarDatosFilaSeleccionada()
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                _idEjercicioSeleccionado = null;
                txtNombreEjercicio.Clear();
                txtDuracion.Clear();
                txtCalorias.Clear();
                txtDescripcion.Clear();
                cmbNivelFisico.SelectedIndex = -1;
                cmbTipoEjercicio.SelectedIndex = -1;
                return;
            }

            _idEjercicioSeleccionado = ObtenerIdDesdeFila(fila);
            txtNombreEjercicio.Text = fila.Cells["colNombre"].Value?.ToString() ?? string.Empty;
            txtDuracion.Text = fila.Cells["colDuracion"].Value?.ToString() ?? string.Empty;
            txtCalorias.Text = fila.Cells["colCalorias"].Value?.ToString() ?? string.Empty;
            txtDescripcion.Text = fila.Cells["colDescripcionGrid"].Value?.ToString() ?? string.Empty;
            SeleccionarEnCombo(cmbTipoEjercicio, fila.Cells["colTipo"].Value?.ToString());
            SeleccionarEnCombo(cmbNivelFisico, fila.Cells["colNivel"].Value?.ToString());
        }

        private DataGridViewRow? ObtenerFilaSeleccionada()
        {
            return dgvEjercicios.SelectedRows.Count > 0 ? dgvEjercicios.SelectedRows[0] : null;
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

        private void SeleccionarFilaPorId(int id)
        {
            _suspenderEventosSeleccion = true;
            try
            {
                foreach (DataGridViewRow row in dgvEjercicios.Rows)
                {
                    var rowId = ObtenerIdDesdeFila(row);
                    if (rowId == id)
                    {
                        row.Selected = true;
                        dgvEjercicios.CurrentCell = row.Cells[0];
                        dgvEjercicios.FirstDisplayedScrollingRowIndex = row.Index;
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

        private bool ValidarFormulario(out int duracion, out int calorias)
        {
            duracion = 0;
            calorias = 0;

            if (string.IsNullOrWhiteSpace(txtNombreEjercicio.Text))
            {
                MessageBox.Show("El nombre del ejercicio es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbNivelFisico.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un nivel físico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbTipoEjercicio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un tipo de ejercicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDuracion.Text, out duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtCalorias.Text) && (!int.TryParse(txtCalorias.Text, out calorias) || calorias < 0))
            {
                MessageBox.Show("Las calorías deben ser un número válido mayor o igual a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarNivelesEnCombo()
        {
            _idsNiveles.Clear();
            cmbNivelFisico.Items.Clear();

            using var context = new SamanaFitContext();
            var niveles = context.Nivels
                .OrderBy(n => n.IdNivel)
                .Select(n => new { n.IdNivel, n.Nombre, n.Descripcion })
                .ToList();

            var nombresAgregados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var nivel in niveles)
            {
                var texto = string.IsNullOrWhiteSpace(nivel.Nombre)
                    ? (nivel.Descripcion ?? $"Nivel {nivel.IdNivel}")
                    : nivel.Nombre;

                if (!nombresAgregados.Add(texto))
                {
                    continue;
                }

                _idsNiveles.Add(nivel.IdNivel);
                cmbNivelFisico.Items.Add(texto);
            }
        }

        private int? ObtenerIdNivelSeleccionado()
        {
            var idx = cmbNivelFisico.SelectedIndex;
            if (idx < 0 || idx >= _idsNiveles.Count)
            {
                return null;
            }

            return _idsNiveles[idx];
        }

        private string ObtenerTextoNivelPorId(int? idNivel)
        {
            if (!idNivel.HasValue)
            {
                return string.Empty;
            }

            using var context = new SamanaFitContext();
            var nivel = context.Nivels.FirstOrDefault(n => n.IdNivel == idNivel.Value);
            if (nivel is null)
            {
                return string.Empty;
            }

            return string.IsNullOrWhiteSpace(nivel.Nombre)
                ? (nivel.Descripcion ?? string.Empty)
                : nivel.Nombre;
        }

        private void LimpiarFormulario()
        {
            _suspenderEventosSeleccion = true;
            _idEjercicioSeleccionado = null;
            txtNombreEjercicio.Clear();
            txtDuracion.Clear();
            txtCalorias.Clear();
            txtDescripcion.Clear();
            cmbNivelFisico.SelectedIndex = -1;
            cmbTipoEjercicio.SelectedIndex = -1;
            dgvEjercicios.ClearSelection();
            dgvEjercicios.CurrentCell = null;
            _suspenderEventosSeleccion = false;
            txtNombreEjercicio.Focus();
        }

        private static void SeleccionarEnCombo(ComboBox combo, string? valor)
        {
            if (combo.Items.Count == 0)
            {
                return;
            }

            var item = combo.Items.Cast<object>()
                .FirstOrDefault(i => string.Equals(i.ToString(), valor ?? string.Empty, StringComparison.OrdinalIgnoreCase));

            combo.SelectedItem = item;

            if (combo.SelectedIndex < 0)
            {
                combo.SelectedIndex = -1;
            }
        }
    }
}
