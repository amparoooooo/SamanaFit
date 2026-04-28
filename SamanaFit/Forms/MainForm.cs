using SamanaFit.Ui.Forms;
using SamanaFit.Data.Context;

namespace SamanaFit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Shown += MainForm_Shown;
            Activated += MainForm_Activated;
        }

        private void MainForm_Shown(object? sender, EventArgs e)
        {
            CargarResumen();
        }

        private void MainForm_Activated(object? sender, EventArgs e)
        {
            CargarResumen();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void btnObjetivos_Click(object sender, EventArgs e)
        {
            var objetivosForm = new ObjetivosForm();
            objetivosForm.Show();
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            var nivelesForm = new NivelesForm();
            nivelesForm.Show();
        }

        private void btnEjercicios_Click(object sender, EventArgs e)
        {
            var ejerciciosForm = new EjerciciosForm();
            ejerciciosForm.Show();
        }

        private void btnRutinas_Click(object sender, EventArgs e)
        {
            var rutinasForm = new RutinasForm();
            rutinasForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var reportesForm = new ReportesForm();
            reportesForm.Show();
        }

        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            var rutinasForm = new RutinasForm();
            rutinasForm.Show();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            var usuariosForm = new UsuariosForm();
            usuariosForm.Show();
        }

        private void btnVerEjercicios_Click(object sender, EventArgs e)
        {
            var ejerciciosForm = new EjerciciosForm();
            ejerciciosForm.Show();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            var reportesForm = new ReportesForm();
            reportesForm.Show();
        }

        private void CargarResumen()
        {
            using var context = new SamanaFitContext();

            var totalUsuarios = context.Usuarios.Count();
            var totalRutinas = context.Rutinas.Count();
            var totalObjetivos = context.Objetivos.Count();
            var totalEjercicios = context.Ejercicios.Count();

            lblNumUsuarios.Text = totalUsuarios.ToString("N0");
            lblNumRutinas.Text = totalRutinas.ToString("N0");
            lblNumObjetivos.Text = totalObjetivos.ToString("N0");
            lblNumEjercicios.Text = totalEjercicios.ToString("N0");
        }
    }
}
