using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using SamanaFit.Data.Context;
using System.Data;

namespace SamanaFit.Ui.Forms
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
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
            if (dgvResultados.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Title = "Guardar reporte en PDF",
                Filter = "PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true,
                FileName = $"reporte_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                ExportarPdf(dialog.FileName);
                MessageBox.Show("Reporte PDF generado correctamente.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo generar el PDF.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object? sender, EventArgs e)
        {
            if (dgvResultados.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new SaveFileDialog
            {
                Title = "Guardar reporte en Excel",
                Filter = "Excel (*.xlsx)|*.xlsx",
                DefaultExt = "xlsx",
                AddExtension = true,
                FileName = $"reporte_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                ExportarExcel(dialog.FileName);
                MessageBox.Show("Reporte Excel generado correctamente.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo generar el Excel.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                var nombre = string.IsNullOrWhiteSpace(usuario.Nombre) ? $"Usuario {usuario.IdUsuario}" : usuario.Nombre;
                cmbUsuario.Items.Add(NormalizarNombreUsuario(nombre));
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
                        ? NormalizarNombreUsuario(r.IdUsuarioNavigation.Nombre)
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

        private static string NormalizarNombreUsuario(string valor)
        {
            return (valor ?? string.Empty).Replace('|', ' ').Trim();
        }

        private void ExportarExcel(string filePath)
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Reporte");

            var colCount = dgvResultados.Columns.Count;
            for (var c = 0; c < colCount; c++)
            {
                ws.Cell(1, c + 1).Value = dgvResultados.Columns[c].HeaderText;
                ws.Cell(1, c + 1).Style.Font.Bold = true;
            }

            var rExcel = 2;
            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                for (var c = 0; c < colCount; c++)
                {
                    ws.Cell(rExcel, c + 1).Value = row.Cells[c].Value?.ToString() ?? string.Empty;
                }

                rExcel++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(filePath);
        }

        private void ExportarPdf(string filePath)
        {
            var doc = new PdfDocument();
            doc.Info.Title = "Reporte del sistema";

            var page = doc.AddPage();
            page.Size = PdfSharpCore.PageSize.A4;
            var gfx = XGraphics.FromPdfPage(page);

            var fontTitle = new XFont("Arial", 14, XFontStyle.Bold);
            var fontHeader = new XFont("Arial", 9, XFontStyle.Bold);
            var fontCell = new XFont("Arial", 9, XFontStyle.Regular);

            const double margin = 36; // 0.5 inch
            var y = margin;

            gfx.DrawString("Reporte del sistema", fontTitle, XBrushes.Black, new XRect(margin, y, page.Width - margin * 2, 20), XStringFormats.TopLeft);
            y += 26;
            gfx.DrawString($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}", fontCell, XBrushes.Black, new XRect(margin, y, page.Width - margin * 2, 14), XStringFormats.TopLeft);
            y += 20;

            var headers = dgvResultados.Columns.Cast<DataGridViewColumn>()
                .Select(c => c.HeaderText)
                .ToList();

            var rows = dgvResultados.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => Enumerable.Range(0, dgvResultados.Columns.Count)
                    .Select(i => r.Cells[i].Value?.ToString() ?? string.Empty)
                    .ToList())
                .ToList();

            var availableWidth = page.Width - margin * 2;
            var colCount = headers.Count;
            var colWidth = availableWidth / Math.Max(1, colCount);

            double rowHeight = 18;
            double headerHeight = 20;

            void NewPage()
            {
                page = doc.AddPage();
                page.Size = PdfSharpCore.PageSize.A4;
                gfx = XGraphics.FromPdfPage(page);
                y = margin;
            }

            void DrawHeader()
            {
                var x = margin;
                for (var i = 0; i < colCount; i++)
                {
                    var rect = new XRect(x, y, colWidth, headerHeight);
                    gfx.DrawRectangle(XBrushes.LightGray, rect);
                    gfx.DrawRectangle(XPens.Gray, rect);
                    gfx.DrawString(headers[i], fontHeader, XBrushes.Black, rect, XStringFormats.Center);
                    x += colWidth;
                }
                y += headerHeight;
            }

            DrawHeader();

            foreach (var row in rows)
            {
                if (y + rowHeight + margin > page.Height)
                {
                    NewPage();
                    DrawHeader();
                }

                var x = margin;
                for (var i = 0; i < colCount; i++)
                {
                    var rect = new XRect(x, y, colWidth, rowHeight);
                    gfx.DrawRectangle(XPens.LightGray, rect);

                    var text = row[i];
                    if (text.Length > 40)
                    {
                        text = text.Substring(0, 37) + "...";
                    }

                    gfx.DrawString(text, fontCell, XBrushes.Black, new XRect(rect.X + 3, rect.Y + 3, rect.Width - 6, rect.Height - 6), XStringFormats.TopLeft);
                    x += colWidth;
                }

                y += rowHeight;
            }

            doc.Save(filePath);
        }
    }
}
