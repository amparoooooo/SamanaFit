namespace SamanaFit.Ui.Forms
{
    partial class ReportesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblHeaderTitle = new Label();
            btnInicio = new Button();
            panelFiltros = new Panel();
            btnExportarExcel = new Button();
            btnExportarPdf = new Button();
            btnReporteObjetivos = new Button();
            btnReporteEjercicios = new Button();
            btnReporteRutinas = new Button();
            btnReporteUsuarios = new Button();
            lblReportesRapidos = new Label();
            btnLimpiarFiltros = new Button();
            btnBuscar = new Button();
            txtFecha = new TextBox();
            lblFecha = new Label();
            cmbNivel = new ComboBox();
            lblNivel = new Label();
            cmbObjetivo = new ComboBox();
            lblObjetivo = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            lblFiltrosTitle = new Label();
            panelResultados = new Panel();
            dgvResultados = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colObjetivo = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colFechaRegistro = new DataGridViewTextBoxColumn();
            colRutinas = new DataGridViewTextBoxColumn();
            lblResultadosTitle = new Label();
            panelHeader.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(btnInicio);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1428, 124);
            panelHeader.TabIndex = 5;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Left;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(227, 0, 82);
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(412, 124);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Reportes del sistema";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Right;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 14F);
            btnInicio.ForeColor = Color.FromArgb(64, 64, 64);
            btnInicio.Image = Properties.Resources.house;
            btnInicio.Location = new Point(1358, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(70, 124);
            btnInicio.TabIndex = 1;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelFiltros
            // 
            panelFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltros.BackColor = Color.White;
            panelFiltros.Controls.Add(btnExportarExcel);
            panelFiltros.Controls.Add(btnExportarPdf);
            panelFiltros.Controls.Add(btnReporteObjetivos);
            panelFiltros.Controls.Add(btnReporteEjercicios);
            panelFiltros.Controls.Add(btnReporteRutinas);
            panelFiltros.Controls.Add(btnReporteUsuarios);
            panelFiltros.Controls.Add(lblReportesRapidos);
            panelFiltros.Controls.Add(btnLimpiarFiltros);
            panelFiltros.Controls.Add(btnBuscar);
            panelFiltros.Controls.Add(txtFecha);
            panelFiltros.Controls.Add(lblFecha);
            panelFiltros.Controls.Add(cmbNivel);
            panelFiltros.Controls.Add(lblNivel);
            panelFiltros.Controls.Add(cmbObjetivo);
            panelFiltros.Controls.Add(lblObjetivo);
            panelFiltros.Controls.Add(cmbUsuario);
            panelFiltros.Controls.Add(lblUsuario);
            panelFiltros.Controls.Add(lblFiltrosTitle);
            panelFiltros.Location = new Point(12, 140);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1404, 520);
            panelFiltros.TabIndex = 6;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(0, 184, 107);
            btnExportarExcel.FlatAppearance.BorderSize = 0;
            btnExportarExcel.FlatStyle = FlatStyle.Flat;
            btnExportarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.Location = new Point(300, 432);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(220, 52);
            btnExportarExcel.TabIndex = 17;
            btnExportarExcel.Text = "📄  Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.BackColor = Color.FromArgb(255, 44, 66);
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.FlatStyle = FlatStyle.Flat;
            btnExportarPdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExportarPdf.ForeColor = Color.White;
            btnExportarPdf.Location = new Point(48, 432);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(220, 52);
            btnExportarPdf.TabIndex = 16;
            btnExportarPdf.Text = "📄  Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = false;
            // 
            // btnReporteObjetivos
            // 
            btnReporteObjetivos.BackColor = Color.White;
            btnReporteObjetivos.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnReporteObjetivos.FlatAppearance.BorderSize = 1;
            btnReporteObjetivos.FlatStyle = FlatStyle.Flat;
            btnReporteObjetivos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReporteObjetivos.ForeColor = Color.FromArgb(35, 56, 85);
            btnReporteObjetivos.Image = Ui.Properties.Resources.target;
            btnReporteObjetivos.ImageAlign = ContentAlignment.TopLeft;
            btnReporteObjetivos.Location = new Point(1110, 275);
            btnReporteObjetivos.Name = "btnReporteObjetivos";
            btnReporteObjetivos.Padding = new Padding(12, 14, 12, 14);
            btnReporteObjetivos.Size = new Size(250, 140);
            btnReporteObjetivos.TabIndex = 15;
            btnReporteObjetivos.Text = "Objetivos más\r\ncomunes";
            btnReporteObjetivos.TextAlign = ContentAlignment.BottomLeft;
            btnReporteObjetivos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReporteObjetivos.UseVisualStyleBackColor = false;
            // 
            // btnReporteEjercicios
            // 
            btnReporteEjercicios.BackColor = Color.White;
            btnReporteEjercicios.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnReporteEjercicios.FlatAppearance.BorderSize = 1;
            btnReporteEjercicios.FlatStyle = FlatStyle.Flat;
            btnReporteEjercicios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReporteEjercicios.ForeColor = Color.FromArgb(35, 56, 85);
            btnReporteEjercicios.Image = Ui.Properties.Resources.dumbbell;
            btnReporteEjercicios.ImageAlign = ContentAlignment.TopLeft;
            btnReporteEjercicios.Location = new Point(824, 275);
            btnReporteEjercicios.Name = "btnReporteEjercicios";
            btnReporteEjercicios.Padding = new Padding(12, 14, 12, 14);
            btnReporteEjercicios.Size = new Size(250, 140);
            btnReporteEjercicios.TabIndex = 14;
            btnReporteEjercicios.Text = "Ejercicios más\r\nusados";
            btnReporteEjercicios.TextAlign = ContentAlignment.BottomLeft;
            btnReporteEjercicios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReporteEjercicios.UseVisualStyleBackColor = false;
            // 
            // btnReporteRutinas
            // 
            btnReporteRutinas.BackColor = Color.White;
            btnReporteRutinas.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnReporteRutinas.FlatAppearance.BorderSize = 1;
            btnReporteRutinas.FlatStyle = FlatStyle.Flat;
            btnReporteRutinas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReporteRutinas.ForeColor = Color.FromArgb(35, 56, 85);
            btnReporteRutinas.Image = Ui.Properties.Resources.list_checks;
            btnReporteRutinas.ImageAlign = ContentAlignment.TopLeft;
            btnReporteRutinas.Location = new Point(538, 275);
            btnReporteRutinas.Name = "btnReporteRutinas";
            btnReporteRutinas.Padding = new Padding(12, 14, 12, 14);
            btnReporteRutinas.Size = new Size(250, 140);
            btnReporteRutinas.TabIndex = 13;
            btnReporteRutinas.Text = "Rutinas\r\ngeneradas";
            btnReporteRutinas.TextAlign = ContentAlignment.BottomLeft;
            btnReporteRutinas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReporteRutinas.UseVisualStyleBackColor = false;
            // 
            // btnReporteUsuarios
            // 
            btnReporteUsuarios.BackColor = Color.White;
            btnReporteUsuarios.FlatAppearance.BorderColor = Color.FromArgb(233, 236, 239);
            btnReporteUsuarios.FlatAppearance.BorderSize = 1;
            btnReporteUsuarios.FlatStyle = FlatStyle.Flat;
            btnReporteUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReporteUsuarios.ForeColor = Color.FromArgb(35, 56, 85);
            btnReporteUsuarios.Image = Ui.Properties.Resources.users;
            btnReporteUsuarios.ImageAlign = ContentAlignment.TopLeft;
            btnReporteUsuarios.Location = new Point(252, 275);
            btnReporteUsuarios.Name = "btnReporteUsuarios";
            btnReporteUsuarios.Padding = new Padding(12, 14, 12, 14);
            btnReporteUsuarios.Size = new Size(250, 140);
            btnReporteUsuarios.TabIndex = 12;
            btnReporteUsuarios.Text = "Usuarios\r\nregistrados";
            btnReporteUsuarios.TextAlign = ContentAlignment.BottomLeft;
            btnReporteUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReporteUsuarios.UseVisualStyleBackColor = false;
            // 
            // lblReportesRapidos
            // 
            lblReportesRapidos.AutoSize = true;
            lblReportesRapidos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReportesRapidos.ForeColor = Color.FromArgb(17, 34, 64);
            lblReportesRapidos.Location = new Point(48, 214);
            lblReportesRapidos.Name = "lblReportesRapidos";
            lblReportesRapidos.Size = new Size(209, 32);
            lblReportesRapidos.TabIndex = 11;
            lblReportesRapidos.Text = "Reportes rápidos";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.FromArgb(52, 126, 238);
            btnLimpiarFiltros.FlatAppearance.BorderSize = 0;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiarFiltros.ForeColor = Color.White;
            btnLimpiarFiltros.Location = new Point(300, 144);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(220, 52);
            btnLimpiarFiltros.TabIndex = 10;
            btnLimpiarFiltros.Text = "✖  Limpiar filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(227, 0, 82);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(48, 144);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(220, 52);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "🔍  Buscar / Filtrar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Font = new Font("Segoe UI", 12F);
            txtFecha.Location = new Point(1100, 86);
            txtFecha.Name = "txtFecha";
            txtFecha.PlaceholderText = "dd/mm/aaaa";
            txtFecha.Size = new Size(260, 34);
            txtFecha.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(35, 56, 85);
            lblFecha.Location = new Point(1100, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(66, 28);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha";
            // 
            // cmbNivel
            // 
            cmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivel.Font = new Font("Segoe UI", 12F);
            cmbNivel.FormattingEnabled = true;
            cmbNivel.Items.AddRange(new object[] { "Todos los niveles" });
            cmbNivel.Location = new Point(730, 86);
            cmbNivel.Name = "cmbNivel";
            cmbNivel.Size = new Size(250, 36);
            cmbNivel.TabIndex = 6;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNivel.ForeColor = Color.FromArgb(35, 56, 85);
            lblNivel.Location = new Point(815, 52);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(62, 28);
            lblNivel.TabIndex = 5;
            lblNivel.Text = "Nivel";
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjetivo.Font = new Font("Segoe UI", 12F);
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Items.AddRange(new object[] { "Todos los objetivos" });
            cmbObjetivo.Location = new Point(404, 86);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(250, 36);
            cmbObjetivo.TabIndex = 4;
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObjetivo.ForeColor = Color.FromArgb(35, 56, 85);
            lblObjetivo.Location = new Point(463, 52);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(93, 28);
            lblObjetivo.TabIndex = 3;
            lblObjetivo.Text = "Objetivo";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 12F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Items.AddRange(new object[] { "Todos los usuarios" });
            cmbUsuario.Location = new Point(59, 84);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(250, 36);
            cmbUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(35, 56, 85);
            lblUsuario.Location = new Point(123, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 28);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblFiltrosTitle
            // 
            lblFiltrosTitle.AutoSize = true;
            lblFiltrosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFiltrosTitle.ForeColor = Color.FromArgb(17, 34, 64);
            lblFiltrosTitle.Location = new Point(48, 20);
            lblFiltrosTitle.Name = "lblFiltrosTitle";
            lblFiltrosTitle.Size = new Size(239, 32);
            lblFiltrosTitle.TabIndex = 0;
            lblFiltrosTitle.Text = "Filtros de búsqueda";
            // 
            // panelResultados
            // 
            panelResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelResultados.BackColor = Color.White;
            panelResultados.Controls.Add(dgvResultados);
            panelResultados.Controls.Add(lblResultadosTitle);
            panelResultados.Location = new Point(12, 676);
            panelResultados.Name = "panelResultados";
            panelResultados.Size = new Size(1404, 540);
            panelResultados.TabIndex = 7;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AllowUserToResizeColumns = false;
            dgvResultados.AllowUserToResizeRows = false;
            dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BackgroundColor = Color.White;
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvResultados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 0, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 0, 82);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultados.ColumnHeadersHeight = 54;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colId, colUsuario, colObjetivo, colNivel, colFechaRegistro, colRutinas });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.GridColor = Color.FromArgb(233, 236, 239);
            dgvResultados.Location = new Point(30, 86);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.RowTemplate.Height = 52;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(1344, 430);
            dgvResultados.TabIndex = 1;
            // 
            // colId
            // 
            colId.FillWeight = 45F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colObjetivo
            // 
            colObjetivo.HeaderText = "Objetivo";
            colObjetivo.MinimumWidth = 6;
            colObjetivo.Name = "colObjetivo";
            colObjetivo.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.MinimumWidth = 6;
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.HeaderText = "Fecha Registro";
            colFechaRegistro.MinimumWidth = 6;
            colFechaRegistro.Name = "colFechaRegistro";
            colFechaRegistro.ReadOnly = true;
            // 
            // colRutinas
            // 
            colRutinas.HeaderText = "Rutinas";
            colRutinas.MinimumWidth = 6;
            colRutinas.Name = "colRutinas";
            colRutinas.ReadOnly = true;
            // 
            // lblResultadosTitle
            // 
            lblResultadosTitle.AutoSize = true;
            lblResultadosTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResultadosTitle.ForeColor = Color.FromArgb(17, 34, 64);
            lblResultadosTitle.Location = new Point(30, 30);
            lblResultadosTitle.Name = "lblResultadosTitle";
            lblResultadosTitle.Size = new Size(138, 32);
            lblResultadosTitle.TabIndex = 0;
            lblResultadosTitle.Text = "Resultados";
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1428, 768);
            Controls.Add(panelResultados);
            Controls.Add(panelFiltros);
            Controls.Add(panelHeader);
            Name = "ReportesForm";
            Text = "ReportesForm";
            panelHeader.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelResultados.ResumeLayout(false);
            panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Button btnInicio;
        private Panel panelFiltros;
        private Button btnExportarExcel;
        private Button btnExportarPdf;
        private Button btnReporteObjetivos;
        private Button btnReporteEjercicios;
        private Button btnReporteRutinas;
        private Button btnReporteUsuarios;
        private Label lblReportesRapidos;
        private Button btnLimpiarFiltros;
        private Button btnBuscar;
        private TextBox txtFecha;
        private Label lblFecha;
        private ComboBox cmbNivel;
        private Label lblNivel;
        private ComboBox cmbObjetivo;
        private Label lblObjetivo;
        private ComboBox cmbUsuario;
        private Label lblUsuario;
        private Label lblFiltrosTitle;
        private Panel panelResultados;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colObjetivo;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colFechaRegistro;
        private DataGridViewTextBoxColumn colRutinas;
        private Label lblResultadosTitle;
    }
}