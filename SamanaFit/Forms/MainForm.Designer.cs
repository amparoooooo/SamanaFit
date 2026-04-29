namespace SamanaFit
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            menuArchivo = new ToolStripMenuItem();
            menuSalir = new ToolStripMenuItem();
            menuAccesos = new ToolStripMenuItem();
            menuAccionesRapidas = new ToolStripMenuItem();
            menuCrearRutina = new ToolStripMenuItem();
            menuRegistrarUsuario = new ToolStripMenuItem();
            menuVerEjercicios = new ToolStripMenuItem();
            menuGenerarReporte = new ToolStripMenuItem();
            menuUsuarios = new ToolStripMenuItem();
            menuObjetivos = new ToolStripMenuItem();
            menuNiveles = new ToolStripMenuItem();
            menuEjercicios = new ToolStripMenuItem();
            menuRutinas = new ToolStripMenuItem();
            menuReportes = new ToolStripMenuItem();
            toolStripAccesos = new ToolStrip();
            toolUsuarios = new ToolStripButton();
            toolObjetivos = new ToolStripButton();
            toolNiveles = new ToolStripButton();
            toolRutinas = new ToolStripButton();
            toolEjercicios = new ToolStripButton();
            toolReportes = new ToolStripButton();
            panelSidebar = new Panel();
            btnReportes = new Button();
            btnRutinas = new Button();
            btnEjercicios = new Button();
            btnNiveles = new Button();
            btnObjetivos = new Button();
            btnUsuarios = new Button();
            lblTitle = new Label();
            btnSalir = new Button();
            panelHeader = new Panel();
            lblHeaderTitle = new Label();
            btnNotificaciones = new Button();
            btnAdministrador = new Button();
            panelDeAcciones = new Panel();
            lblAccionesRapidas = new Label();
            tableLayoutPanelAcciones = new TableLayoutPanel();
            btnCrearRutina = new Button();
            btnRegistrarUsuario = new Button();
            btnVerEjercicios = new Button();
            btnGenerarReporte = new Button();
            panelDeBienvenida = new Panel();
            lblBienvenidaSub = new Label();
            lblBienvenidaTitle = new Label();
            panelTarjetas = new TableLayoutPanel();
            cardUsuarios = new Panel();
            pictureBox1 = new PictureBox();
            lblNumUsuarios = new Label();
            lblTotalUsuarios = new Label();
            cardRutinas = new Panel();
            pictureBox2 = new PictureBox();
            lblNumRutinas = new Label();
            lblRutinasGeneradas = new Label();
            cardObjetivos = new Panel();
            pictureBox3 = new PictureBox();
            lblNumObjetivos = new Label();
            lblObjetivosActivos = new Label();
            cardEjercicios = new Panel();
            pictureBox4 = new PictureBox();
            lblNumEjercicios = new Label();
            lblEjerciciosDisp = new Label();
            menuStripMain.SuspendLayout();
            toolStripAccesos.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelDeAcciones.SuspendLayout();
            tableLayoutPanelAcciones.SuspendLayout();
            panelDeBienvenida.SuspendLayout();
            panelTarjetas.SuspendLayout();
            cardUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cardRutinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            cardObjetivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            cardEjercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { menuArchivo, menuAccesos, menuAccionesRapidas });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1127, 28);
            menuStripMain.TabIndex = 5;
            menuStripMain.Text = "menuStripMain";
            // 
            // menuArchivo
            // 
            menuArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuSalir });
            menuArchivo.Name = "menuArchivo";
            menuArchivo.Size = new Size(73, 24);
            menuArchivo.Text = "Archivo";
            // 
            // menuSalir
            // 
            menuSalir.Name = "menuSalir";
            menuSalir.Size = new Size(120, 26);
            menuSalir.Text = "Salir";
            menuSalir.Click += menuSalir_Click;
            // 
            // menuAccesos
            // 
            menuAccesos.DropDownItems.AddRange(new ToolStripItem[] { menuUsuarios, menuObjetivos, menuNiveles, menuEjercicios, menuRutinas, menuReportes });
            menuAccesos.Name = "menuAccesos";
            menuAccesos.Size = new Size(76, 24);
            menuAccesos.Text = "Accesos";
            // 
            // menuUsuarios
            // 
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(156, 26);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuObjetivos
            // 
            menuObjetivos.Name = "menuObjetivos";
            menuObjetivos.Size = new Size(156, 26);
            menuObjetivos.Text = "Objetivos";
            menuObjetivos.Click += menuObjetivos_Click;
            // 
            // menuNiveles
            // 
            menuNiveles.Name = "menuNiveles";
            menuNiveles.Size = new Size(156, 26);
            menuNiveles.Text = "Niveles";
            menuNiveles.Click += menuNiveles_Click;
            // 
            // menuEjercicios
            // 
            menuEjercicios.Name = "menuEjercicios";
            menuEjercicios.Size = new Size(156, 26);
            menuEjercicios.Text = "Ejercicios";
            menuEjercicios.Click += menuEjercicios_Click;
            // 
            // menuRutinas
            // 
            menuRutinas.Name = "menuRutinas";
            menuRutinas.Size = new Size(156, 26);
            menuRutinas.Text = "Rutinas";
            menuRutinas.Click += menuRutinas_Click;
            // 
            // menuReportes
            // 
            menuReportes.Name = "menuReportes";
            menuReportes.Size = new Size(156, 26);
            menuReportes.Text = "Reportes";
            menuReportes.Click += menuReportes_Click;
            // 
            // menuAccionesRapidas
            // 
            menuAccionesRapidas.DropDownItems.AddRange(new ToolStripItem[] { menuCrearRutina, menuRegistrarUsuario, menuVerEjercicios, menuGenerarReporte });
            menuAccionesRapidas.Name = "menuAccionesRapidas";
            menuAccionesRapidas.Size = new Size(133, 24);
            menuAccionesRapidas.Text = "Acciones rápidas";
            // 
            // menuCrearRutina
            // 
            menuCrearRutina.Name = "menuCrearRutina";
            menuCrearRutina.Size = new Size(224, 26);
            menuCrearRutina.Text = "Crear Rutina";
            menuCrearRutina.Click += btnCrearRutina_Click;
            // 
            // menuRegistrarUsuario
            // 
            menuRegistrarUsuario.Name = "menuRegistrarUsuario";
            menuRegistrarUsuario.Size = new Size(224, 26);
            menuRegistrarUsuario.Text = "Registrar Usuario";
            menuRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // menuVerEjercicios
            // 
            menuVerEjercicios.Name = "menuVerEjercicios";
            menuVerEjercicios.Size = new Size(224, 26);
            menuVerEjercicios.Text = "Ver Ejercicios";
            menuVerEjercicios.Click += btnVerEjercicios_Click;
            // 
            // menuGenerarReporte
            // 
            menuGenerarReporte.Name = "menuGenerarReporte";
            menuGenerarReporte.Size = new Size(224, 26);
            menuGenerarReporte.Text = "Generar Reporte";
            menuGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // toolStripAccesos
            // 
            toolStripAccesos.ImageScalingSize = new Size(20, 20);
            toolStripAccesos.Items.AddRange(new ToolStripItem[] { toolUsuarios, toolObjetivos, toolNiveles, toolRutinas, toolEjercicios, toolReportes });
            toolStripAccesos.Location = new Point(0, 28);
            toolStripAccesos.Name = "toolStripAccesos";
            toolStripAccesos.Size = new Size(1127, 27);
            toolStripAccesos.TabIndex = 6;
            toolStripAccesos.Text = "toolStripAccesos";
            // 
            // toolUsuarios
            // 
            toolUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolUsuarios.Image = Ui.Properties.Resources.users;
            toolUsuarios.ImageTransparentColor = Color.Magenta;
            toolUsuarios.Name = "toolUsuarios";
            toolUsuarios.Size = new Size(76, 24);
            toolUsuarios.Text = "Usuarios";
            toolUsuarios.Click += menuUsuarios_Click;
            // 
            // toolObjetivos
            // 
            toolObjetivos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolObjetivos.Image = Ui.Properties.Resources.target;
            toolObjetivos.ImageTransparentColor = Color.Magenta;
            toolObjetivos.Name = "toolObjetivos";
            toolObjetivos.Size = new Size(29, 24);
            toolObjetivos.Text = "Objetivos";
            toolObjetivos.Click += menuObjetivos_Click;
            // 
            // toolNiveles
            // 
            toolNiveles.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolNiveles.Image = Ui.Properties.Resources.trending_up;
            toolNiveles.ImageTransparentColor = Color.Magenta;
            toolNiveles.Name = "toolNiveles";
            toolNiveles.Size = new Size(29, 24);
            toolNiveles.Text = "Niveles";
            toolNiveles.Click += menuNiveles_Click;
            // 
            // toolRutinas
            // 
            toolRutinas.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolRutinas.Image = Ui.Properties.Resources.list_checks;
            toolRutinas.ImageTransparentColor = Color.Magenta;
            toolRutinas.Name = "toolRutinas";
            toolRutinas.Size = new Size(64, 24);
            toolRutinas.Text = "Rutinas";
            toolRutinas.Click += menuRutinas_Click;
            // 
            // toolEjercicios
            // 
            toolEjercicios.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolEjercicios.Image = Ui.Properties.Resources.dumbbell;
            toolEjercicios.ImageTransparentColor = Color.Magenta;
            toolEjercicios.Name = "toolEjercicios";
            toolEjercicios.Size = new Size(82, 24);
            toolEjercicios.Text = "Ejercicios";
            toolEjercicios.Click += menuEjercicios_Click;
            // 
            // toolReportes
            // 
            toolReportes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolReportes.Image = Ui.Properties.Resources.chart_column;
            toolReportes.ImageTransparentColor = Color.Magenta;
            toolReportes.Name = "toolReportes";
            toolReportes.Size = new Size(76, 24);
            toolReportes.Text = "Reportes";
            toolReportes.Click += menuReportes_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(227, 0, 82);
            panelSidebar.Controls.Add(btnReportes);
            panelSidebar.Controls.Add(btnRutinas);
            panelSidebar.Controls.Add(btnEjercicios);
            panelSidebar.Controls.Add(btnNiveles);
            panelSidebar.Controls.Add(btnObjetivos);
            panelSidebar.Controls.Add(btnUsuarios);
            panelSidebar.Controls.Add(lblTitle);
            panelSidebar.Controls.Add(btnSalir);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 55);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 672);
            panelSidebar.TabIndex = 0;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = Ui.Properties.Resources.chart_column;
            btnReportes.Location = new Point(0, 380);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(250, 50);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "  Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnRutinas
            // 
            btnRutinas.Dock = DockStyle.Top;
            btnRutinas.FlatAppearance.BorderSize = 0;
            btnRutinas.FlatStyle = FlatStyle.Flat;
            btnRutinas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRutinas.ForeColor = Color.White;
            btnRutinas.Image = Ui.Properties.Resources.list_checks;
            btnRutinas.Location = new Point(0, 330);
            btnRutinas.Name = "btnRutinas";
            btnRutinas.Size = new Size(250, 50);
            btnRutinas.TabIndex = 6;
            btnRutinas.Text = "  Rutinas";
            btnRutinas.TextAlign = ContentAlignment.MiddleLeft;
            btnRutinas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRutinas.Click += btnRutinas_Click;
            // 
            // btnEjercicios
            // 
            btnEjercicios.Dock = DockStyle.Top;
            btnEjercicios.FlatAppearance.BorderSize = 0;
            btnEjercicios.FlatStyle = FlatStyle.Flat;
            btnEjercicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEjercicios.ForeColor = Color.White;
            btnEjercicios.Image = Ui.Properties.Resources.dumbbell;
            btnEjercicios.Location = new Point(0, 280);
            btnEjercicios.Name = "btnEjercicios";
            btnEjercicios.Size = new Size(250, 50);
            btnEjercicios.TabIndex = 5;
            btnEjercicios.Text = "  Ejercicios";
            btnEjercicios.TextAlign = ContentAlignment.MiddleLeft;
            btnEjercicios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEjercicios.Click += btnEjercicios_Click;
            // 
            // btnNiveles
            // 
            btnNiveles.Dock = DockStyle.Top;
            btnNiveles.FlatAppearance.BorderSize = 0;
            btnNiveles.FlatStyle = FlatStyle.Flat;
            btnNiveles.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNiveles.ForeColor = Color.White;
            btnNiveles.Image = Ui.Properties.Resources.trending_up;
            btnNiveles.Location = new Point(0, 230);
            btnNiveles.Name = "btnNiveles";
            btnNiveles.Size = new Size(250, 50);
            btnNiveles.TabIndex = 4;
            btnNiveles.Text = "  Niveles";
            btnNiveles.TextAlign = ContentAlignment.MiddleLeft;
            btnNiveles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNiveles.Click += btnNiveles_Click;
            // 
            // btnObjetivos
            // 
            btnObjetivos.Dock = DockStyle.Top;
            btnObjetivos.FlatAppearance.BorderSize = 0;
            btnObjetivos.FlatStyle = FlatStyle.Flat;
            btnObjetivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnObjetivos.ForeColor = Color.White;
            btnObjetivos.Image = Ui.Properties.Resources.target;
            btnObjetivos.Location = new Point(0, 180);
            btnObjetivos.Name = "btnObjetivos";
            btnObjetivos.Size = new Size(250, 50);
            btnObjetivos.TabIndex = 3;
            btnObjetivos.Text = "  Objetivos";
            btnObjetivos.TextAlign = ContentAlignment.MiddleLeft;
            btnObjetivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnObjetivos.Click += btnObjetivos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Ui.Properties.Resources.users;
            btnUsuarios.Location = new Point(0, 130);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 50);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "  Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Image = Ui.Properties.Resources.dumbbell;
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SamanáFit Pro";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Ui.Properties.Resources.log_out;
            btnSalir.Location = new Point(0, 677);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 50);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "  Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(btnNotificaciones);
            panelHeader.Controls.Add(btnAdministrador);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(250, 55);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(877, 124);
            panelHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Left;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(227, 0, 82);
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(300, 124);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "  Panel de Control";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.Dock = DockStyle.Right;
            btnNotificaciones.FlatAppearance.BorderSize = 0;
            btnNotificaciones.FlatStyle = FlatStyle.Flat;
            btnNotificaciones.Font = new Font("Segoe UI", 14F);
            btnNotificaciones.ForeColor = Color.FromArgb(64, 64, 64);
            btnNotificaciones.Image = Ui.Properties.Resources.bell;
            btnNotificaciones.Location = new Point(607, 0);
            btnNotificaciones.Name = "btnNotificaciones";
            btnNotificaciones.Size = new Size(70, 124);
            btnNotificaciones.TabIndex = 2;
            btnNotificaciones.Click += btnNotificaciones_Click;
            // 
            // btnAdministrador
            // 
            btnAdministrador.Dock = DockStyle.Right;
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.Font = new Font("Segoe UI", 12F);
            btnAdministrador.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdministrador.Image = Ui.Properties.Resources.circle_user;
            btnAdministrador.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministrador.Location = new Point(677, 0);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(200, 124);
            btnAdministrador.TabIndex = 1;
            btnAdministrador.Text = " Administrador";
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // panelDeAcciones
            // 
            panelDeAcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDeAcciones.BackColor = Color.White;
            panelDeAcciones.Controls.Add(lblAccionesRapidas);
            panelDeAcciones.Controls.Add(tableLayoutPanelAcciones);
            panelDeAcciones.Location = new Point(256, 561);
            panelDeAcciones.Name = "panelDeAcciones";
            panelDeAcciones.Size = new Size(859, 166);
            panelDeAcciones.TabIndex = 2;
            // 
            // lblAccionesRapidas
            // 
            lblAccionesRapidas.AutoSize = true;
            lblAccionesRapidas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccionesRapidas.ForeColor = Color.FromArgb(17, 34, 64);
            lblAccionesRapidas.Location = new Point(20, 15);
            lblAccionesRapidas.Name = "lblAccionesRapidas";
            lblAccionesRapidas.Size = new Size(176, 28);
            lblAccionesRapidas.TabIndex = 0;
            lblAccionesRapidas.Text = "Acciones Rápidas";
            // 
            // tableLayoutPanelAcciones
            // 
            tableLayoutPanelAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelAcciones.ColumnCount = 4;
            tableLayoutPanelAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelAcciones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelAcciones.Controls.Add(btnCrearRutina, 0, 0);
            tableLayoutPanelAcciones.Controls.Add(btnRegistrarUsuario, 1, 0);
            tableLayoutPanelAcciones.Controls.Add(btnVerEjercicios, 2, 0);
            tableLayoutPanelAcciones.Controls.Add(btnGenerarReporte, 3, 0);
            tableLayoutPanelAcciones.Location = new Point(20, 64);
            tableLayoutPanelAcciones.Name = "tableLayoutPanelAcciones";
            tableLayoutPanelAcciones.RowCount = 1;
            tableLayoutPanelAcciones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelAcciones.Size = new Size(823, 90);
            tableLayoutPanelAcciones.TabIndex = 1;
            // 
            // btnCrearRutina
            // 
            btnCrearRutina.BackColor = Color.FromArgb(255, 43, 115);
            btnCrearRutina.Dock = DockStyle.Fill;
            btnCrearRutina.FlatAppearance.BorderSize = 0;
            btnCrearRutina.FlatStyle = FlatStyle.Flat;
            btnCrearRutina.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrearRutina.ForeColor = Color.White;
            btnCrearRutina.Location = new Point(3, 3);
            btnCrearRutina.Margin = new Padding(3, 3, 10, 3);
            btnCrearRutina.Name = "btnCrearRutina";
            btnCrearRutina.Size = new Size(192, 84);
            btnCrearRutina.TabIndex = 1;
            btnCrearRutina.Text = "Crear Rutina";
            btnCrearRutina.UseVisualStyleBackColor = false;
            btnCrearRutina.Click += btnCrearRutina_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.BackColor = Color.FromArgb(215, 75, 235);
            btnRegistrarUsuario.Dock = DockStyle.Fill;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegistrarUsuario.ForeColor = Color.White;
            btnRegistrarUsuario.Location = new Point(215, 3);
            btnRegistrarUsuario.Margin = new Padding(10, 3, 10, 3);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(185, 84);
            btnRegistrarUsuario.TabIndex = 2;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // btnVerEjercicios
            // 
            btnVerEjercicios.BackColor = Color.FromArgb(100, 130, 255);
            btnVerEjercicios.Dock = DockStyle.Fill;
            btnVerEjercicios.FlatAppearance.BorderSize = 0;
            btnVerEjercicios.FlatStyle = FlatStyle.Flat;
            btnVerEjercicios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerEjercicios.ForeColor = Color.White;
            btnVerEjercicios.Location = new Point(420, 3);
            btnVerEjercicios.Margin = new Padding(10, 3, 10, 3);
            btnVerEjercicios.Name = "btnVerEjercicios";
            btnVerEjercicios.Size = new Size(185, 84);
            btnVerEjercicios.TabIndex = 3;
            btnVerEjercicios.Text = "Ver Ejercicios";
            btnVerEjercicios.UseVisualStyleBackColor = false;
            btnVerEjercicios.Click += btnVerEjercicios_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(255, 43, 115);
            btnGenerarReporte.Dock = DockStyle.Fill;
            btnGenerarReporte.FlatAppearance.BorderSize = 0;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(625, 3);
            btnGenerarReporte.Margin = new Padding(10, 3, 3, 3);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(195, 84);
            btnGenerarReporte.TabIndex = 4;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // panelDeBienvenida
            // 
            panelDeBienvenida.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelDeBienvenida.BackColor = Color.FromArgb(255, 43, 115);
            panelDeBienvenida.Controls.Add(lblBienvenidaSub);
            panelDeBienvenida.Controls.Add(lblBienvenidaTitle);
            panelDeBienvenida.Location = new Point(256, 366);
            panelDeBienvenida.Name = "panelDeBienvenida";
            panelDeBienvenida.Size = new Size(859, 160);
            panelDeBienvenida.TabIndex = 3;
            // 
            // lblBienvenidaSub
            // 
            lblBienvenidaSub.Anchor = AnchorStyles.None;
            lblBienvenidaSub.AutoSize = true;
            lblBienvenidaSub.Font = new Font("Segoe UI", 12F);
            lblBienvenidaSub.ForeColor = Color.White;
            lblBienvenidaSub.Location = new Point(253, 90);
            lblBienvenidaSub.Name = "lblBienvenidaSub";
            lblBienvenidaSub.Size = new Size(377, 28);
            lblBienvenidaSub.TabIndex = 1;
            lblBienvenidaSub.Text = "Entrena inteligente y alcanza tus objetivos";
            lblBienvenidaSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenidaTitle
            // 
            lblBienvenidaTitle.Anchor = AnchorStyles.None;
            lblBienvenidaTitle.AutoSize = true;
            lblBienvenidaTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenidaTitle.ForeColor = Color.White;
            lblBienvenidaTitle.Location = new Point(188, 30);
            lblBienvenidaTitle.Name = "lblBienvenidaTitle";
            lblBienvenidaTitle.Size = new Size(551, 54);
            lblBienvenidaTitle.TabIndex = 0;
            lblBienvenidaTitle.Text = "Bienvenido a SamanáFit Pro";
            lblBienvenidaTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTarjetas
            // 
            panelTarjetas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTarjetas.ColumnCount = 4;
            panelTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelTarjetas.Controls.Add(cardUsuarios, 0, 0);
            panelTarjetas.Controls.Add(cardRutinas, 1, 0);
            panelTarjetas.Controls.Add(cardObjetivos, 2, 0);
            panelTarjetas.Controls.Add(cardEjercicios, 3, 0);
            panelTarjetas.Location = new Point(256, 161);
            panelTarjetas.Name = "panelTarjetas";
            panelTarjetas.RowCount = 1;
            panelTarjetas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelTarjetas.Size = new Size(849, 189);
            panelTarjetas.TabIndex = 4;
            // 
            // cardUsuarios
            // 
            cardUsuarios.BackColor = Color.White;
            cardUsuarios.Controls.Add(pictureBox1);
            cardUsuarios.Controls.Add(lblNumUsuarios);
            cardUsuarios.Controls.Add(lblTotalUsuarios);
            cardUsuarios.Dock = DockStyle.Fill;
            cardUsuarios.Location = new Point(10, 10);
            cardUsuarios.Margin = new Padding(10);
            cardUsuarios.Name = "cardUsuarios";
            cardUsuarios.Size = new Size(192, 169);
            cardUsuarios.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Ui.Properties.Resources.users;
            pictureBox1.Location = new Point(73, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 26);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblNumUsuarios
            // 
            lblNumUsuarios.AutoSize = true;
            lblNumUsuarios.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNumUsuarios.ForeColor = Color.FromArgb(17, 34, 64);
            lblNumUsuarios.Location = new Point(15, 75);
            lblNumUsuarios.Name = "lblNumUsuarios";
            lblNumUsuarios.Size = new Size(109, 46);
            lblNumUsuarios.TabIndex = 0;
            lblNumUsuarios.Text = "2,847";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 10F);
            lblTotalUsuarios.ForeColor = Color.Gray;
            lblTotalUsuarios.Location = new Point(15, 50);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(140, 23);
            lblTotalUsuarios.TabIndex = 1;
            lblTotalUsuarios.Text = "Total de Usuarios";
            // 
            // cardRutinas
            // 
            cardRutinas.BackColor = Color.White;
            cardRutinas.Controls.Add(pictureBox2);
            cardRutinas.Controls.Add(lblNumRutinas);
            cardRutinas.Controls.Add(lblRutinasGeneradas);
            cardRutinas.Dock = DockStyle.Fill;
            cardRutinas.Location = new Point(222, 10);
            cardRutinas.Margin = new Padding(10);
            cardRutinas.Name = "cardRutinas";
            cardRutinas.Size = new Size(192, 169);
            cardRutinas.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Ui.Properties.Resources.list_checks;
            pictureBox2.Location = new Point(78, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 26);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblNumRutinas
            // 
            lblNumRutinas.AutoSize = true;
            lblNumRutinas.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNumRutinas.ForeColor = Color.FromArgb(17, 34, 64);
            lblNumRutinas.Location = new Point(15, 75);
            lblNumRutinas.Name = "lblNumRutinas";
            lblNumRutinas.Size = new Size(109, 46);
            lblNumRutinas.TabIndex = 0;
            lblNumRutinas.Text = "1,234";
            // 
            // lblRutinasGeneradas
            // 
            lblRutinasGeneradas.AutoSize = true;
            lblRutinasGeneradas.Font = new Font("Segoe UI", 10F);
            lblRutinasGeneradas.ForeColor = Color.Gray;
            lblRutinasGeneradas.Location = new Point(15, 50);
            lblRutinasGeneradas.Name = "lblRutinasGeneradas";
            lblRutinasGeneradas.Size = new Size(152, 23);
            lblRutinasGeneradas.TabIndex = 1;
            lblRutinasGeneradas.Text = "Rutinas Generadas";
            // 
            // cardObjetivos
            // 
            cardObjetivos.BackColor = Color.White;
            cardObjetivos.Controls.Add(pictureBox3);
            cardObjetivos.Controls.Add(lblNumObjetivos);
            cardObjetivos.Controls.Add(lblObjetivosActivos);
            cardObjetivos.Dock = DockStyle.Fill;
            cardObjetivos.Location = new Point(434, 10);
            cardObjetivos.Margin = new Padding(10);
            cardObjetivos.Name = "cardObjetivos";
            cardObjetivos.Size = new Size(192, 169);
            cardObjetivos.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Ui.Properties.Resources.target;
            pictureBox3.Location = new Point(72, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 27);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblNumObjetivos
            // 
            lblNumObjetivos.AutoSize = true;
            lblNumObjetivos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNumObjetivos.ForeColor = Color.FromArgb(17, 34, 64);
            lblNumObjetivos.Location = new Point(15, 75);
            lblNumObjetivos.Name = "lblNumObjetivos";
            lblNumObjetivos.Size = new Size(80, 46);
            lblNumObjetivos.TabIndex = 0;
            lblNumObjetivos.Text = "567";
            // 
            // lblObjetivosActivos
            // 
            lblObjetivosActivos.AutoSize = true;
            lblObjetivosActivos.Font = new Font("Segoe UI", 10F);
            lblObjetivosActivos.ForeColor = Color.Gray;
            lblObjetivosActivos.Location = new Point(15, 50);
            lblObjetivosActivos.Name = "lblObjetivosActivos";
            lblObjetivosActivos.Size = new Size(140, 23);
            lblObjetivosActivos.TabIndex = 1;
            lblObjetivosActivos.Text = "Objetivos Activos";
            // 
            // cardEjercicios
            // 
            cardEjercicios.BackColor = Color.White;
            cardEjercicios.Controls.Add(pictureBox4);
            cardEjercicios.Controls.Add(lblNumEjercicios);
            cardEjercicios.Controls.Add(lblEjerciciosDisp);
            cardEjercicios.Dock = DockStyle.Fill;
            cardEjercicios.Location = new Point(646, 10);
            cardEjercicios.Margin = new Padding(10);
            cardEjercicios.Name = "cardEjercicios";
            cardEjercicios.Size = new Size(193, 169);
            cardEjercicios.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Ui.Properties.Resources.dumbbell;
            pictureBox4.Location = new Point(81, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 29);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lblNumEjercicios
            // 
            lblNumEjercicios.AutoSize = true;
            lblNumEjercicios.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNumEjercicios.ForeColor = Color.FromArgb(17, 34, 64);
            lblNumEjercicios.Location = new Point(15, 75);
            lblNumEjercicios.Name = "lblNumEjercicios";
            lblNumEjercicios.Size = new Size(80, 46);
            lblNumEjercicios.TabIndex = 0;
            lblNumEjercicios.Text = "892";
            // 
            // lblEjerciciosDisp
            // 
            lblEjerciciosDisp.AutoSize = true;
            lblEjerciciosDisp.Font = new Font("Segoe UI", 10F);
            lblEjerciciosDisp.ForeColor = Color.Gray;
            lblEjerciciosDisp.Location = new Point(15, 50);
            lblEjerciciosDisp.Name = "lblEjerciciosDisp";
            lblEjerciciosDisp.Size = new Size(171, 23);
            lblEjerciciosDisp.TabIndex = 1;
            lblEjerciciosDisp.Text = "Ejercicios Disponibles";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1127, 727);
            Controls.Add(panelTarjetas);
            Controls.Add(panelDeBienvenida);
            Controls.Add(panelDeAcciones);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            Controls.Add(toolStripAccesos);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            Text = "SamanaFit";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStripAccesos.ResumeLayout(false);
            toolStripAccesos.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelDeAcciones.ResumeLayout(false);
            panelDeAcciones.PerformLayout();
            tableLayoutPanelAcciones.ResumeLayout(false);
            panelDeBienvenida.ResumeLayout(false);
            panelDeBienvenida.PerformLayout();
            panelTarjetas.ResumeLayout(false);
            cardUsuarios.ResumeLayout(false);
            cardUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cardRutinas.ResumeLayout(false);
            cardRutinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            cardObjetivos.ResumeLayout(false);
            cardObjetivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            cardEjercicios.ResumeLayout(false);
            cardEjercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem menuSalir;
        private ToolStripMenuItem menuAccesos;
        private ToolStripMenuItem menuAccionesRapidas;
        private ToolStripMenuItem menuCrearRutina;
        private ToolStripMenuItem menuRegistrarUsuario;
        private ToolStripMenuItem menuVerEjercicios;
        private ToolStripMenuItem menuGenerarReporte;
        private ToolStripMenuItem menuUsuarios;
        private ToolStripMenuItem menuObjetivos;
        private ToolStripMenuItem menuNiveles;
        private ToolStripMenuItem menuEjercicios;
        private ToolStripMenuItem menuRutinas;
        private ToolStripMenuItem menuReportes;
        private ToolStrip toolStripAccesos;
        private ToolStripButton toolUsuarios;
        private ToolStripButton toolObjetivos;
        private ToolStripButton toolNiveles;
        private ToolStripButton toolRutinas;
        private ToolStripButton toolEjercicios;
        private ToolStripButton toolReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnRutinas;
        private System.Windows.Forms.Button btnEjercicios;
        private System.Windows.Forms.Button btnNiveles;
        private System.Windows.Forms.Button btnObjetivos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Panel panelDeAcciones;
        private System.Windows.Forms.Label lblAccionesRapidas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAcciones;
        private System.Windows.Forms.Button btnCrearRutina;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnVerEjercicios;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Panel panelDeBienvenida;
        private System.Windows.Forms.Label lblBienvenidaTitle;
        private System.Windows.Forms.Label lblBienvenidaSub;
        private System.Windows.Forms.TableLayoutPanel panelTarjetas;
        private System.Windows.Forms.Panel cardUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblNumUsuarios;
        private System.Windows.Forms.Panel cardRutinas;
        private System.Windows.Forms.Label lblRutinasGeneradas;
        private System.Windows.Forms.Label lblNumRutinas;
        private System.Windows.Forms.Panel cardObjetivos;
        private System.Windows.Forms.Label lblObjetivosActivos;
        private System.Windows.Forms.Label lblNumObjetivos;
        private System.Windows.Forms.Panel cardEjercicios;
        private System.Windows.Forms.Label lblEjerciciosDisp;
        private System.Windows.Forms.Label lblNumEjercicios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
