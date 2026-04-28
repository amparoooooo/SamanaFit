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
    public partial class NivelesForm : Form
    {
        private bool _suspenderEventosSeleccion;
        private int? _idNivelSeleccionado;

        public NivelesForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
            CargarNivelesDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void ConfigurarFormulario()
        {
            dgvNiveles.SelectionChanged += dgvNiveles_SelectionChanged;
            dgvNiveles.CellClick += dgvNiveles_CellClick;
            Shown += NivelesForm_Shown;
        }

        private void NivelesForm_Shown(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario(out var nombreNivel))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var nivel = new Nivel
            {
                Nombre = nombreNivel,
                Descripcion = txtDescripcionNivel.Text.Trim()
            };

            context.Nivels.Add(nivel);
            context.SaveChanges();

            var idGuardado = nivel.IdNivel;
            CargarNivelesDesdeBaseDatos();
            SeleccionarFilaPorId(idGuardado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idNivelSeleccionado is null)
            {
                MessageBox.Show("Selecciona un nivel para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarFormulario(out var nombreNivel))
            {
                return;
            }

            using var context = new SamanaFitContext();
            var nivel = context.Nivels.FirstOrDefault(n => n.IdNivel == _idNivelSeleccionado.Value);
            if (nivel is null)
            {
                MessageBox.Show("No se encontró el nivel seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarNivelesDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            nivel.Nombre = nombreNivel;
            nivel.Descripcion = txtDescripcionNivel.Text.Trim();
            context.SaveChanges();

            var idEditado = nivel.IdNivel;
            CargarNivelesDesdeBaseDatos();
            SeleccionarFilaPorId(idEditado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idNivelSeleccionado is null)
            {
                MessageBox.Show("Selecciona un nivel para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Deseas eliminar el nivel seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            using var context = new SamanaFitContext();
            var nivel = context.Nivels.FirstOrDefault(n => n.IdNivel == _idNivelSeleccionado.Value);
            if (nivel is null)
            {
                MessageBox.Show("No se encontró el nivel seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarNivelesDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            context.Nivels.Remove(nivel);
            context.SaveChanges();

            CargarNivelesDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvNiveles_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private void dgvNiveles_CellClick(object? sender, DataGridViewCellEventArgs e)
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

        private void CargarNivelesDesdeBaseDatos()
        {
            _suspenderEventosSeleccion = true;
            dgvNiveles.Rows.Clear();

            using var context = new SamanaFitContext();
            var niveles = context.Nivels
                .OrderBy(n => n.IdNivel)
                .ToList();

            foreach (var nivel in niveles)
            {
                var nombreNivel = string.IsNullOrWhiteSpace(nivel.Nombre)
                    ? (nivel.Descripcion ?? string.Empty)
                    : nivel.Nombre;

                var descripcionNivel = string.IsNullOrWhiteSpace(nivel.Nombre)
                    ? string.Empty
                    : (nivel.Descripcion ?? string.Empty);

                dgvNiveles.Rows.Add(
                    nivel.IdNivel,
                    nombreNivel,
                    descripcionNivel);
            }

            dgvNiveles.ClearSelection();
            dgvNiveles.CurrentCell = null;
            _suspenderEventosSeleccion = false;
        }

        private void CargarDatosFilaSeleccionada()
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                _idNivelSeleccionado = null;
                cmbNombreNivel.SelectedIndex = 0;
                txtDescripcionNivel.Clear();
                return;
            }

            _idNivelSeleccionado = ObtenerIdDesdeFila(fila);

            var nombreNivel = fila.Cells["colNombreNivel"].Value?.ToString() ?? string.Empty;
            cmbNombreNivel.SelectedItem = cmbNombreNivel.Items.Cast<object>()
                .FirstOrDefault(item => string.Equals(item.ToString(), nombreNivel, StringComparison.OrdinalIgnoreCase));

            if (cmbNombreNivel.SelectedIndex < 0)
            {
                cmbNombreNivel.SelectedIndex = 0;
            }

            txtDescripcionNivel.Text = fila.Cells["colDescripcion"].Value?.ToString() ?? string.Empty;
        }

        private DataGridViewRow? ObtenerFilaSeleccionada()
        {
            return dgvNiveles.SelectedRows.Count > 0 ? dgvNiveles.SelectedRows[0] : null;
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
                foreach (DataGridViewRow row in dgvNiveles.Rows)
                {
                    var rowId = ObtenerIdDesdeFila(row);
                    if (rowId == id)
                    {
                        row.Selected = true;
                        dgvNiveles.CurrentCell = row.Cells[0];
                        dgvNiveles.FirstDisplayedScrollingRowIndex = row.Index;
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

        private bool ValidarFormulario(out string nombreNivel)
        {
            nombreNivel = string.Empty;

            if (cmbNombreNivel.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecciona un nombre de nivel.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            nombreNivel = cmbNombreNivel.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nombreNivel))
            {
                MessageBox.Show("Selecciona un nombre de nivel válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcionNivel.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            _suspenderEventosSeleccion = true;
            _idNivelSeleccionado = null;
            cmbNombreNivel.SelectedIndex = 0;
            txtDescripcionNivel.Clear();
            dgvNiveles.ClearSelection();
            dgvNiveles.CurrentCell = null;
            _suspenderEventosSeleccion = false;
            cmbNombreNivel.Focus();
        }
    }
}
