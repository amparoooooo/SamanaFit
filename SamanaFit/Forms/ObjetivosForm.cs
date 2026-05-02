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
    public partial class ObjetivosForm : Form
    {
        private bool _suspenderEventosSeleccion;
        private int? _idObjetivoSeleccionado;

        public ObjetivosForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            ConfigurarFormulario();
            CargarObjetivosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            using var context = new SamanaFitContext();
            var objetivo = new Objetivo
            {
                Nombre = txtNombreObjetivo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            context.Objetivos.Add(objetivo);
            context.SaveChanges();

            var idGuardado = objetivo.IdObjetivo;
            CargarObjetivosDesdeBaseDatos();
            SeleccionarFilaPorId(idGuardado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_idObjetivoSeleccionado is null)
            {
                MessageBox.Show("Selecciona un objetivo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidarFormulario())
            {
                return;
            }

            using var context = new SamanaFitContext();
            var objetivo = context.Objetivos.FirstOrDefault(o => o.IdObjetivo == _idObjetivoSeleccionado.Value);
            if (objetivo is null)
            {
                MessageBox.Show("No se encontró el objetivo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarObjetivosDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            objetivo.Nombre = txtNombreObjetivo.Text.Trim();
            objetivo.Descripcion = txtDescripcion.Text.Trim();
            context.SaveChanges();

            var idEditado = objetivo.IdObjetivo;
            CargarObjetivosDesdeBaseDatos();
            SeleccionarFilaPorId(idEditado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idObjetivoSeleccionado is null)
            {
                MessageBox.Show("Selecciona un objetivo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                "¿Deseas eliminar el objetivo seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            using var context = new SamanaFitContext();
            var objetivo = context.Objetivos.FirstOrDefault(o => o.IdObjetivo == _idObjetivoSeleccionado.Value);
            if (objetivo is null)
            {
                MessageBox.Show("No se encontró el objetivo seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarObjetivosDesdeBaseDatos();
                LimpiarFormulario();
                return;
            }

            context.Objetivos.Remove(objetivo);
            context.SaveChanges();

            CargarObjetivosDesdeBaseDatos();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarFormulario()
        {
            dgvObjetivos.SelectionChanged += dgvObjetivos_SelectionChanged;
            dgvObjetivos.CellClick += dgvObjetivos_CellClick;
            Shown += ObjetivosForm_Shown;
        }

        private void ObjetivosForm_Shown(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void dgvObjetivos_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suspenderEventosSeleccion)
            {
                return;
            }

            CargarDatosFilaSeleccionada();
        }

        private void dgvObjetivos_CellClick(object? sender, DataGridViewCellEventArgs e)
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

        private void CargarObjetivosDesdeBaseDatos()
        {
            _suspenderEventosSeleccion = true;
            dgvObjetivos.Rows.Clear();

            using var context = new SamanaFitContext();
            var objetivos = context.Objetivos
                .OrderBy(o => o.IdObjetivo)
                .ToList();

            foreach (var objetivo in objetivos)
            {
                dgvObjetivos.Rows.Add(
                    objetivo.IdObjetivo,
                    objetivo.Nombre ?? "",
                    objetivo.Descripcion ?? "");
            }

            dgvObjetivos.ClearSelection();
            dgvObjetivos.CurrentCell = null;
            _suspenderEventosSeleccion = false;
        }

        private void CargarDatosFilaSeleccionada()
        {
            var fila = ObtenerFilaSeleccionada();
            if (fila is null)
            {
                _idObjetivoSeleccionado = null;
                txtNombreObjetivo.Clear();
                txtDescripcion.Clear();
                return;
            }

            _idObjetivoSeleccionado = ObtenerIdDesdeFila(fila);
            txtNombreObjetivo.Text = fila.Cells["colNombreObjetivo"].Value?.ToString() ?? string.Empty;
            txtDescripcion.Text = fila.Cells["colDescripcion"].Value?.ToString() ?? string.Empty;
        }

        private DataGridViewRow? ObtenerFilaSeleccionada()
        {
            return dgvObjetivos.SelectedRows.Count > 0 ? dgvObjetivos.SelectedRows[0] : null;
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
                foreach (DataGridViewRow row in dgvObjetivos.Rows)
                {
                    var rowId = ObtenerIdDesdeFila(row);
                    if (rowId == id)
                    {
                        row.Selected = true;
                        dgvObjetivos.CurrentCell = row.Cells[0];
                        dgvObjetivos.FirstDisplayedScrollingRowIndex = row.Index;
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

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(txtNombreObjetivo.Text))
            {
                MessageBox.Show("El nombre del objetivo es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarFormulario()
        {
            _suspenderEventosSeleccion = true;
            _idObjetivoSeleccionado = null;
            txtNombreObjetivo.Clear();
            txtDescripcion.Clear();
            dgvObjetivos.ClearSelection();
            dgvObjetivos.CurrentCell = null;
            _suspenderEventosSeleccion = false;
            txtNombreObjetivo.Focus();
        }
    }
}
