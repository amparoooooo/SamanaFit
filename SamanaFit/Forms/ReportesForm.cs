using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SamanaFit.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace SamanaFit.Ui.Forms
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }
        private void ConfigurarFormulario()
        {
            btnBuscar.Click += btnBuscar_Click;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            btnExportarPdf.Click += btnExportarPdf_Click;
            btnExportarExcel.Click += btnExportarExcel_Click;
           

            CargarFiltrosPorDefecto();
            CargarResultados();
        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            CargarResultados();
        }

        private void btnLimpiarFiltros_Click(object? sender, EventArgs e)
        {
            CargarFiltrosPorDefecto();
            CargarResultados();
        }

        private void btnExportarPdf_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Exportación PDF en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarExcel_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Exportación Excel en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteUsuarios_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Reporte de usuarios registrados en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteRutinas_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Reporte de rutinas generadas en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteEjercicios_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Reporte de ejercicios más usados en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteObjetivos_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Reporte de objetivos más comunes en construcción.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarFiltrosPorDefecto()
        {
            cmbUsuario.Items.Clear();
            cmbObjetivo.Items.Clear();
            cmbNivel.Items.Clear();

            cmbUsuario.Items.Add("Todos los usuarios");
            cmbObjetivo.Items.Add("Todos los objetivos");
            cmbNivel.Items.Add("Todos los niveles");

            using var context = new SamanaFitContext();

            foreach (var usuario in context.Usuarios.OrderBy(u => u.IdUsuario).ToList())
            {
                cmbUsuario.Items.Add(string.IsNullOrWhiteSpace(usuario.Nombre) ? $"Usuario {usuario.IdUsuario}" : usuario.Nombre);
            }

            var objetivos = context.Objetivos
                .OrderBy(o => o.IdObjetivo)
                .ToList()
                .Select(objetivo => string.IsNullOrWhiteSpace(objetivo.Nombre)
                    ? $"Objetivo {objetivo.IdObjetivo}"
                    : objetivo.Nombre)
                .Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var objetivo in objetivos)
            {
                cmbObjetivo.Items.Add(objetivo);
            }

            var niveles = context.Nivels
                .OrderBy(n => n.IdNivel)
                .ToList()
                .Select(nivel => string.IsNullOrWhiteSpace(nivel.Nombre)
                    ? (nivel.Descripcion ?? $"Nivel {nivel.IdNivel}")
                    : nivel.Nombre)
                .Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var nivel in niveles)
            {
                cmbNivel.Items.Add(nivel);
            }

            cmbUsuario.SelectedIndex = 0;
            cmbObjetivo.SelectedIndex = 0;
            cmbNivel.SelectedIndex = 0;
            txtFecha.Clear();
        }

        private void CargarResultados()
        {
            dgvResultados.Rows.Clear();
            using var context = new SamanaFitContext();

            var rutinas = context.Rutinas
                .Include(r => r.IdUsuarioNavigation)
                .Include(r => r.IdObjetivoNavigation)
                .Include(r => r.IdNivelNavigation)
                .OrderBy(r => r.IdRutina)
                .ToList();

            var resultados = rutinas.Select(r => new
                {
                    r.IdRutina,
                    Usuario = r.IdUsuarioNavigation != null && !string.IsNullOrWhiteSpace(r.IdUsuarioNavigation.Nombre)
                        ? r.IdUsuarioNavigation.Nombre
                        : (r.IdUsuario.HasValue ? $"Usuario {r.IdUsuario.Value}" : string.Empty),
                    Objetivo = r.IdObjetivoNavigation != null && !string.IsNullOrWhiteSpace(r.IdObjetivoNavigation.Nombre)
                        ? r.IdObjetivoNavigation.Nombre
                        : (r.IdObjetivo.HasValue ? $"Objetivo {r.IdObjetivo.Value}" : string.Empty),
                    Nivel = r.IdNivelNavigation != null
                        ? (string.IsNullOrWhiteSpace(r.IdNivelNavigation.Nombre)
                            ? (r.IdNivelNavigation.Descripcion ?? string.Empty)
                            : r.IdNivelNavigation.Nombre)
                        : (r.IdNivel.HasValue ? $"Nivel {r.IdNivel.Value}" : string.Empty),
                    Fecha = r.FechaCreacion,
                    r.DuracionSemanas
                })
                .ToList();

            if (cmbUsuario.SelectedIndex > 0)
            {
                var usuario = cmbUsuario.SelectedItem?.ToString() ?? string.Empty;
                resultados = resultados.Where(r => r.Usuario == usuario).ToList();
            }

            if (cmbObjetivo.SelectedIndex > 0)
            {
                var objetivo = cmbObjetivo.SelectedItem?.ToString() ?? string.Empty;
                resultados = resultados.Where(r => r.Objetivo == objetivo).ToList();
            }

            if (cmbNivel.SelectedIndex > 0)
            {
                var nivel = cmbNivel.SelectedItem?.ToString() ?? string.Empty;
                resultados = resultados.Where(r => r.Nivel == nivel).ToList();
            }

            if (DateOnly.TryParse(txtFecha.Text, out var fechaFiltro))
            {
                resultados = resultados.Where(r => r.Fecha == fechaFiltro).ToList();
            }
            foreach (var resultado in resultados)
            {
                dgvResultados.Rows.Add(
                    resultado.IdRutina,
                    resultado.Usuario,
                    resultado.Objetivo,
                    resultado.Nivel,
                    resultado.Fecha?.ToString("yyyy-MM-dd") ?? string.Empty,
                    resultado.DuracionSemanas?.ToString() ?? string.Empty);
            }

            dgvResultados.ClearSelection();
            dgvResultados.CurrentCell = null;
        }
    }
}
