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
    public partial class RutinasForm : Form
    {
        private readonly List<int> _idsUsuarios = new();
        private readonly List<int> _idsObjetivos = new();
        private readonly List<int> _idsNiveles = new();

        private bool _suspenderEventos;
        private int? _idRutinaSeleccionada;

        public RutinasForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
            InicializarCamposPorDefecto();
            CargarCatalogos();
            CargarRutinas();
            LimpiarFormulario();
        }

        private void ConfigurarFormulario()
        {
            btnGuardar.Click += btnGuardar_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnGenerarRutina.Click += btnGenerarRutina_Click;
            btnDetalleAgregar.Click += btnDetalleAgregar_Click;
            btnDetalleEditar.Click += btnDetalleEditar_Click;
            btnDetalleEliminar.Click += btnDetalleEliminar_Click;

            dgvRutinas.SelectionChanged += dgvRutinas_SelectionChanged;
            dgvRutinas.CellClick += dgvRutinas_CellClick;

            Shown += RutinasForm_Shown;
        }

        private void RutinasForm_Shown(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void InicializarCamposPorDefecto()
        {
            txtFechaCreacion.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtIdRutina.Text = GenerarSiguienteCodigoRutina();
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            if (!ValidarFormulario(out var idUsuario, out var idObjetivo, out var idNivel, out var duracion))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var rutina = new Rutina
            {
                IdUsuario = idUsuario,
                IdObjetivo = idObjetivo,
                IdNivel = idNivel,
                DuracionSemanas = duracion,
                Observaciones = txtObservaciones.Text.Trim(),
                FechaCreacion = DateOnly.FromDateTime(DateTime.Today),
                Nombre = cmbObjetivo.SelectedItem?.ToString()
            };

            context.Rutinas.Add(rutina);
            context.SaveChanges();

            CargarRutinas();
            SeleccionarRutina(rutina.IdRutina);
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            if (_idRutinaSeleccionada is null)
            {
                MessageBox.Show("Selecciona una rutina para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarFormulario(out var idUsuario, out var idObjetivo, out var idNivel, out var duracion))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var rutina = context.Rutinas.FirstOrDefault(r => r.IdRutina == _idRutinaSeleccionada.Value);
            if (rutina is null)
            {
                MessageBox.Show("No se encontró la rutina seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarRutinas();
                LimpiarFormulario();
                return;
            }

            rutina.IdUsuario = idUsuario;
            rutina.IdObjetivo = idObjetivo;
            rutina.IdNivel = idNivel;
            rutina.DuracionSemanas = duracion;
            rutina.Observaciones = txtObservaciones.Text.Trim();
            rutina.Nombre = cmbObjetivo.SelectedItem?.ToString();
            context.SaveChanges();

            CargarRutinas();
            SeleccionarRutina(rutina.IdRutina);
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            if (_idRutinaSeleccionada is null)
            {
                MessageBox.Show("Selecciona una rutina para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Deseas eliminar la rutina seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            using var context = new SamanaFitContext();
            var rutina = context.Rutinas.FirstOrDefault(r => r.IdRutina == _idRutinaSeleccionada.Value);
            if (rutina is null)
            {
                MessageBox.Show("No se encontró la rutina seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarRutinas();
                LimpiarFormulario();
                return;
            }

            var detalles = context.DetalleRutinas.Where(d => d.IdRutina == rutina.IdRutina).ToList();
            if (detalles.Count > 0)
            {
                context.DetalleRutinas.RemoveRange(detalles);
            }

            context.Rutinas.Remove(rutina);
            context.SaveChanges();

            CargarRutinas();
            LimpiarFormulario();
        }

        private void btnGenerarRutina_Click(object? sender, EventArgs e)
        {
            if (_idRutinaSeleccionada is null)
            {
                MessageBox.Show("Primero guarda o selecciona una rutina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var context = new SamanaFitContext();
            var existentes = context.DetalleRutinas
                .Where(d => d.IdRutina == _idRutinaSeleccionada.Value)
                .Select(d => d.IdEjercicio)
                .ToHashSet();

            const int minimoEjercicios = 5;
            var ejercicios = context.Ejercicios
                .OrderBy(ej => ej.IdEjercicio)
                .Where(ej => !existentes.Contains(ej.IdEjercicio))
                .Take(minimoEjercicios)
                .ToList();

            if (ejercicios.Count == 0)
            {
                MessageBox.Show("No hay ejercicios disponibles para generar la rutina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ejercicios.Count < minimoEjercicios)
            {
                MessageBox.Show(
                    $"Solo hay {ejercicios.Count} ejercicios disponibles para agregar a esta rutina (mínimo deseado: {minimoEjercicios}).",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            foreach (var ejercicio in ejercicios)
            {
                context.DetalleRutinas.Add(new DetalleRutina
                {
                    IdRutina = _idRutinaSeleccionada.Value,
                    IdEjercicio = ejercicio.IdEjercicio,
                    Series = 4,
                    Repeticiones = 12,
                    Descanso = 45
                });
            }

            context.SaveChanges();
            CargarDetalleRutina(_idRutinaSeleccionada.Value);
        }

        private void btnDetalleAgregar_Click(object? sender, EventArgs e)
        {
            if (_idRutinaSeleccionada is null)
            {
                MessageBox.Show("Selecciona una rutina para agregar ejercicios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var context = new SamanaFitContext();
            var usados = context.DetalleRutinas
                .Where(d => d.IdRutina == _idRutinaSeleccionada.Value)
                .Select(d => d.IdEjercicio)
                .ToHashSet();

            var ejercicio = context.Ejercicios
                .OrderBy(e => e.IdEjercicio)
                .FirstOrDefault(e => !usados.Contains(e.IdEjercicio));

            if (ejercicio is null)
            {
                MessageBox.Show("No hay ejercicios disponibles para agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            context.DetalleRutinas.Add(new DetalleRutina
            {
                IdRutina = _idRutinaSeleccionada.Value,
                IdEjercicio = ejercicio.IdEjercicio,
                Series = 4,
                Repeticiones = 12,
                Descanso = 45
            });
            context.SaveChanges();

            CargarDetalleRutina(_idRutinaSeleccionada.Value);
        }

        private void btnDetalleEditar_Click(object? sender, EventArgs e)
        {
            if (dgvEjerciciosRutina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un ejercicio del detalle para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvEjerciciosRutina.SelectedRows[0].Tag is not int idDetalle)
            {
                MessageBox.Show("No se pudo identificar el detalle seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new SamanaFitContext();
            var detalle = context.DetalleRutinas.FirstOrDefault(d => d.IdDetalle == idDetalle);
            if (detalle is null)
            {
                return;
            }

            detalle.Series = (detalle.Series ?? 0) + 1;
            context.SaveChanges();

            if (_idRutinaSeleccionada.HasValue)
            {
                CargarDetalleRutina(_idRutinaSeleccionada.Value);
            }
        }

        private void btnDetalleEliminar_Click(object? sender, EventArgs e)
        {
            if (dgvEjerciciosRutina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un ejercicio del detalle para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvEjerciciosRutina.SelectedRows[0].Tag is not int idDetalle)
            {
                MessageBox.Show("No se pudo identificar el detalle seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new SamanaFitContext();
            var detalle = context.DetalleRutinas.FirstOrDefault(d => d.IdDetalle == idDetalle);
            if (detalle is null)
            {
                return;
            }

            context.DetalleRutinas.Remove(detalle);
            context.SaveChanges();

            if (_idRutinaSeleccionada.HasValue)
            {
                CargarDetalleRutina(_idRutinaSeleccionada.Value);
            }
        }

        private void dgvRutinas_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suspenderEventos)
            {
                return;
            }

            CargarRutinaSeleccionada();
        }

        private void dgvRutinas_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _suspenderEventos)
            {
                return;
            }

            CargarRutinaSeleccionada();
        }

        private void CargarCatalogos()
        {
            _idsUsuarios.Clear();
            _idsObjetivos.Clear();
            _idsNiveles.Clear();

            cmbUsuario.Items.Clear();
            cmbObjetivo.Items.Clear();
            cmbNivelFisico.Items.Clear();

            cmbUsuario.Items.Add("Seleccione un usuario");
            cmbObjetivo.Items.Add("Seleccione un objetivo");
            cmbNivelFisico.Items.Add("Seleccione un nivel");

            using var context = new SamanaFitContext();

            foreach (var usuario in context.Usuarios.OrderBy(u => u.IdUsuario).ToList())
            {
                _idsUsuarios.Add(usuario.IdUsuario);
                cmbUsuario.Items.Add(string.IsNullOrWhiteSpace(usuario.Nombre) ? $"Usuario {usuario.IdUsuario}" : usuario.Nombre);
            }

            var objetivos = context.Objetivos
                .OrderBy(o => o.IdObjetivo)
                .ToList()
                .GroupBy(o => string.IsNullOrWhiteSpace(o.Nombre) ? $"Objetivo {o.IdObjetivo}" : o.Nombre)
                .Select(g => g.First());

            foreach (var objetivo in objetivos)
            {
                _idsObjetivos.Add(objetivo.IdObjetivo);
                cmbObjetivo.Items.Add(string.IsNullOrWhiteSpace(objetivo.Nombre) ? $"Objetivo {objetivo.IdObjetivo}" : objetivo.Nombre);
            }

            var niveles = context.Nivels
                .OrderBy(n => n.IdNivel)
                .ToList()
                .GroupBy(n => string.IsNullOrWhiteSpace(n.Nombre) ? (n.Descripcion ?? $"Nivel {n.IdNivel}") : n.Nombre)
                .Select(g => g.First());

            foreach (var nivel in niveles)
            {
                _idsNiveles.Add(nivel.IdNivel);
                cmbNivelFisico.Items.Add(string.IsNullOrWhiteSpace(nivel.Nombre) ? (nivel.Descripcion ?? $"Nivel {nivel.IdNivel}") : nivel.Nombre);
            }
        }

        private void CargarRutinas()
        {
            _suspenderEventos = true;
            dgvRutinas.Rows.Clear();

            using var context = new SamanaFitContext();
            var rutinas = context.Rutinas
                .OrderBy(r => r.IdRutina)
                .ToList();

            foreach (var rutina in rutinas)
            {
                dgvRutinas.Rows.Add(
                    rutina.IdRutina,
                    ObtenerNombreUsuarioPorId(rutina.IdUsuario),
                    ObtenerNombreObjetivoPorId(rutina.IdObjetivo),
                    ObtenerNombreNivelPorId(rutina.IdNivel),
                    rutina.FechaCreacion?.ToString("yyyy-MM-dd") ?? string.Empty,
                    rutina.DuracionSemanas.HasValue ? $"{rutina.DuracionSemanas.Value} semanas" : string.Empty);
            }

            dgvRutinas.ClearSelection();
            dgvRutinas.CurrentCell = null;
            dgvEjerciciosRutina.Rows.Clear();
            _suspenderEventos = false;
        }

        private void CargarRutinaSeleccionada()
        {
            if (dgvRutinas.SelectedRows.Count == 0)
            {
                _idRutinaSeleccionada = null;
                txtIdRutina.Text = GenerarSiguienteCodigoRutina();
                txtFechaCreacion.Text = DateTime.Today.ToString("dd/MM/yyyy");
                txtDuracionSemanas.Text = "8";
                txtObservaciones.Clear();
                cmbUsuario.SelectedIndex = 0;
                cmbObjetivo.SelectedIndex = 0;
                cmbNivelFisico.SelectedIndex = 0;
                dgvEjerciciosRutina.Rows.Clear();
                return;
            }

            var row = dgvRutinas.SelectedRows[0];
            if (!int.TryParse(row.Cells["colRutinaId"].Value?.ToString(), out var idRutina))
            {
                return;
            }

            _idRutinaSeleccionada = idRutina;

            using var context = new SamanaFitContext();
            var rutina = context.Rutinas.FirstOrDefault(r => r.IdRutina == idRutina);
            if (rutina is null)
            {
                return;
            }

            txtIdRutina.Text = $"RUT-{rutina.IdRutina:000}";
            txtFechaCreacion.Text = (rutina.FechaCreacion?.ToDateTime(TimeOnly.MinValue) ?? DateTime.Today).ToString("dd/MM/yyyy");
            txtDuracionSemanas.Text = rutina.DuracionSemanas?.ToString() ?? "8";
            txtObservaciones.Text = rutina.Observaciones ?? string.Empty;

            SeleccionarComboPorTexto(cmbUsuario, ObtenerNombreUsuarioPorId(rutina.IdUsuario), 0);
            SeleccionarComboPorTexto(cmbObjetivo, ObtenerNombreObjetivoPorId(rutina.IdObjetivo), 0);
            SeleccionarComboPorTexto(cmbNivelFisico, ObtenerNombreNivelPorId(rutina.IdNivel), 0);

            CargarDetalleRutina(idRutina);
        }

        private void CargarDetalleRutina(int idRutina)
        {
            dgvEjerciciosRutina.Rows.Clear();

            using var context = new SamanaFitContext();
            var detalles = context.DetalleRutinas
                .Where(d => d.IdRutina == idRutina)
                .OrderBy(d => d.IdDetalle)
                .ToList();

            foreach (var detalle in detalles)
            {
                var ejercicio = context.Ejercicios.FirstOrDefault(e => e.IdEjercicio == detalle.IdEjercicio);
                var idx = dgvEjerciciosRutina.Rows.Add(
                    ejercicio?.Nombre ?? string.Empty,
                    detalle.Series?.ToString() ?? string.Empty,
                    detalle.Repeticiones?.ToString() ?? string.Empty,
                    (detalle.Descanso?.ToString() ?? string.Empty) + (detalle.Descanso.HasValue ? " min" : string.Empty));

                dgvEjerciciosRutina.Rows[idx].Tag = detalle.IdDetalle;
            }

            dgvEjerciciosRutina.ClearSelection();
            dgvEjerciciosRutina.CurrentCell = null;
        }

        private bool ValidarFormulario(out int idUsuario, out int idObjetivo, out int idNivel, out int duracion)
        {
            idUsuario = 0;
            idObjetivo = 0;
            idNivel = 0;
            duracion = 0;

            if (cmbUsuario.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona un usuario.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbObjetivo.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona un objetivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbNivelFisico.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona un nivel físico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDuracionSemanas.Text, out duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número mayor que 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var idxUsuario = cmbUsuario.SelectedIndex - 1;
            if (idxUsuario < 0 || idxUsuario >= _idsUsuarios.Count)
            {
                MessageBox.Show("No se pudo resolver el usuario seleccionado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var idxObjetivo = cmbObjetivo.SelectedIndex - 1;
            if (idxObjetivo < 0 || idxObjetivo >= _idsObjetivos.Count)
            {
                MessageBox.Show("No se pudo resolver el objetivo seleccionado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var idxNivel = cmbNivelFisico.SelectedIndex - 1;
            if (idxNivel < 0 || idxNivel >= _idsNiveles.Count)
            {
                MessageBox.Show("No se pudo resolver el nivel seleccionado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            idUsuario = _idsUsuarios[idxUsuario];
            idObjetivo = _idsObjetivos[idxObjetivo];
            idNivel = _idsNiveles[idxNivel];
            return true;
        }

        private string GenerarSiguienteCodigoRutina()
        {
            using var context = new SamanaFitContext();
            var ultimoId = context.Rutinas
                .OrderByDescending(r => r.IdRutina)
                .Select(r => r.IdRutina)
                .FirstOrDefault();

            return $"RUT-{(ultimoId + 1):000}";
        }

        private string ObtenerNombreUsuarioPorId(int? idUsuario)
        {
            if (!idUsuario.HasValue)
            {
                return string.Empty;
            }

            using var context = new SamanaFitContext();
            var usuario = context.Usuarios.FirstOrDefault(u => u.IdUsuario == idUsuario.Value);
            return usuario?.Nombre ?? string.Empty;
        }

        private string ObtenerNombreObjetivoPorId(int? idObjetivo)
        {
            if (!idObjetivo.HasValue)
            {
                return string.Empty;
            }

            using var context = new SamanaFitContext();
            var objetivo = context.Objetivos.FirstOrDefault(o => o.IdObjetivo == idObjetivo.Value);
            return objetivo?.Nombre ?? string.Empty;
        }

        private string ObtenerNombreNivelPorId(int? idNivel)
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

        private static void SeleccionarComboPorTexto(ComboBox combo, string valor, int fallback)
        {
            var item = combo.Items.Cast<object>()
                .FirstOrDefault(i => string.Equals(i.ToString(), valor, StringComparison.OrdinalIgnoreCase));

            combo.SelectedItem = item;
            if (combo.SelectedIndex < 0)
            {
                combo.SelectedIndex = fallback;
            }
        }

        private void SeleccionarRutina(int idRutina)
        {
            _suspenderEventos = true;
            try
            {
                foreach (DataGridViewRow row in dgvRutinas.Rows)
                {
                    if (int.TryParse(row.Cells["colRutinaId"].Value?.ToString(), out var id) && id == idRutina)
                    {
                        row.Selected = true;
                        dgvRutinas.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            finally
            {
                _suspenderEventos = false;
            }

            CargarRutinaSeleccionada();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpiarFormulario()
        {
            txtDuracionSemanas.Text = string.Empty;
            txtObservaciones.Clear();
            _idRutinaSeleccionada = null;
            txtIdRutina.Text = GenerarSiguienteCodigoRutina();

            if (cmbUsuario.Items.Count > 0)
            {
                cmbUsuario.SelectedIndex = 0;
            }

            if (cmbObjetivo.Items.Count > 0)
            {
                cmbObjetivo.SelectedIndex = 0;
            }

            if (cmbNivelFisico.Items.Count > 0)
            {
                cmbNivelFisico.SelectedIndex = 0;
            }

            txtFechaCreacion.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dgvRutinas.ClearSelection();
            dgvRutinas.CurrentCell = null;
            dgvEjerciciosRutina.Rows.Clear();
        }
    }
}
