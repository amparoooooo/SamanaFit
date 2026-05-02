namespace SamanaFit.Ui.Forms
{
    partial class RutinasForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblHeaderTitle = new Label();
            btnInicio = new Button();
            panelFormulario = new Panel();
            btnGenerarRutina = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            txtDuracionSemanas = new TextBox();
            lblDuracionSemanas = new Label();
            cmbNivelFisico = new ComboBox();
            lblNivelFisico = new Label();
            cmbObjetivo = new ComboBox();
            lblObjetivo = new Label();
            cmbUsuario = new ComboBox();
            lblUsuario = new Label();
            txtFechaCreacion = new TextBox();
            lblFechaCreacion = new Label();
            txtIdRutina = new TextBox();
            lblIdRutina = new Label();
            panelEjerciciosRutina = new Panel();
            dgvEjerciciosRutina = new DataGridView();
            colEjercicio = new DataGridViewTextBoxColumn();
            colSeries = new DataGridViewTextBoxColumn();
            colRepeticiones = new DataGridViewTextBoxColumn();
            colTiempo = new DataGridViewTextBoxColumn();
            lblEjerciciosRutinaTitle = new Label();
            panelRutinasRegistradas = new Panel();
            dgvRutinas = new DataGridView();
            colRutinaId = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colObjetivoGrid = new DataGridViewTextBoxColumn();
            colNivelGrid = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            lblRutinasRegistradasTitle = new Label();
            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelEjerciciosRutina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjerciciosRutina).BeginInit();
            panelRutinasRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).BeginInit();
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
            panelHeader.Size = new Size(1199, 100);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Left;
            lblHeaderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(227, 0, 82);
            lblHeaderTitle.Location = new Point(0, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(412, 100);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Gestión de rutinas";
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
            btnInicio.Location = new Point(1129, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(70, 100);
            btnInicio.TabIndex = 1;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.BackColor = Color.White;
            panelFormulario.Controls.Add(btnGenerarRutina);
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnEditar);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(txtObservaciones);
            panelFormulario.Controls.Add(lblObservaciones);
            panelFormulario.Controls.Add(txtDuracionSemanas);
            panelFormulario.Controls.Add(lblDuracionSemanas);
            panelFormulario.Controls.Add(cmbNivelFisico);
            panelFormulario.Controls.Add(lblNivelFisico);
            panelFormulario.Controls.Add(cmbObjetivo);
            panelFormulario.Controls.Add(lblObjetivo);
            panelFormulario.Controls.Add(cmbUsuario);
            panelFormulario.Controls.Add(lblUsuario);
            panelFormulario.Controls.Add(txtFechaCreacion);
            panelFormulario.Controls.Add(lblFechaCreacion);
            panelFormulario.Controls.Add(txtIdRutina);
            panelFormulario.Controls.Add(lblIdRutina);
            panelFormulario.Location = new Point(12, 110);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1154, 420);
            panelFormulario.TabIndex = 1;
            // 
            // btnGenerarRutina
            // 
            btnGenerarRutina.BackColor = Color.FromArgb(0, 184, 107);
            btnGenerarRutina.FlatAppearance.BorderSize = 0;
            btnGenerarRutina.FlatStyle = FlatStyle.Flat;
            btnGenerarRutina.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnGenerarRutina.ForeColor = Color.White;
            btnGenerarRutina.Location = new Point(736, 340);
            btnGenerarRutina.Name = "btnGenerarRutina";
            btnGenerarRutina.Size = new Size(430, 56);
            btnGenerarRutina.TabIndex = 18;
            btnGenerarRutina.Text = "✨  Generar Rutina\r\nAutomática";
            btnGenerarRutina.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 126, 238);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(546, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 56);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "🔄  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 44, 66);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(380, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 56);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 67, 232);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(214, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(160, 56);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(227, 0, 82);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(48, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 56);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
            txtObservaciones.Font = new Font("Segoe UI", 12F);
            txtObservaciones.Location = new Point(596, 214);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Ingrese observaciones adicionales...";
            txtObservaciones.Size = new Size(570, 60);
            txtObservaciones.TabIndex = 13;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObservaciones.ForeColor = Color.FromArgb(35, 56, 85);
            lblObservaciones.Location = new Point(596, 183);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(150, 28);
            lblObservaciones.TabIndex = 12;
            lblObservaciones.Text = "Observaciones";
            // 
            // txtDuracionSemanas
            // 
            txtDuracionSemanas.BorderStyle = BorderStyle.FixedSingle;
            txtDuracionSemanas.Font = new Font("Segoe UI", 12F);
            txtDuracionSemanas.Location = new Point(596, 146);
            txtDuracionSemanas.Name = "txtDuracionSemanas";
            txtDuracionSemanas.Size = new Size(570, 34);
            txtDuracionSemanas.TabIndex = 11;
            // 
            // lblDuracionSemanas
            // 
            lblDuracionSemanas.AutoSize = true;
            lblDuracionSemanas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDuracionSemanas.ForeColor = Color.FromArgb(35, 56, 85);
            lblDuracionSemanas.Location = new Point(596, 115);
            lblDuracionSemanas.Name = "lblDuracionSemanas";
            lblDuracionSemanas.Size = new Size(201, 28);
            lblDuracionSemanas.TabIndex = 10;
            lblDuracionSemanas.Text = "Duración (Semanas)";
            // 
            // cmbNivelFisico
            // 
            cmbNivelFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelFisico.Font = new Font("Segoe UI", 12F);
            cmbNivelFisico.FormattingEnabled = true;
            cmbNivelFisico.Items.AddRange(new object[] { "Seleccione un nivel", "Principiante", "Intermedio", "Avanzado" });
            cmbNivelFisico.Location = new Point(48, 298);
            cmbNivelFisico.Name = "cmbNivelFisico";
            cmbNivelFisico.Size = new Size(498, 36);
            cmbNivelFisico.TabIndex = 9;
            // 
            // lblNivelFisico
            // 
            lblNivelFisico.AutoSize = true;
            lblNivelFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNivelFisico.ForeColor = Color.FromArgb(35, 56, 85);
            lblNivelFisico.Location = new Point(48, 267);
            lblNivelFisico.Name = "lblNivelFisico";
            lblNivelFisico.Size = new Size(136, 28);
            lblNivelFisico.TabIndex = 8;
            lblNivelFisico.Text = "Nivel Físico *";
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjetivo.Font = new Font("Segoe UI", 12F);
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Items.AddRange(new object[] { "Seleccione un objetivo" });
            cmbObjetivo.Location = new Point(48, 224);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(498, 36);
            cmbObjetivo.TabIndex = 7;
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObjetivo.ForeColor = Color.FromArgb(35, 56, 85);
            lblObjetivo.Location = new Point(48, 193);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(108, 28);
            lblObjetivo.TabIndex = 6;
            lblObjetivo.Text = "Objetivo *";
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.Font = new Font("Segoe UI", 12F);
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Items.AddRange(new object[] { "Seleccione un usuario" });
            cmbUsuario.Location = new Point(48, 146);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(498, 36);
            cmbUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(35, 56, 85);
            lblUsuario.Location = new Point(48, 115);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(99, 28);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario *";
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCreacion.Font = new Font("Segoe UI", 12F);
            txtFechaCreacion.Location = new Point(596, 77);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.ReadOnly = true;
            txtFechaCreacion.Size = new Size(570, 34);
            txtFechaCreacion.TabIndex = 3;
            // 
            // lblFechaCreacion
            // 
            lblFechaCreacion.AutoSize = true;
            lblFechaCreacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFechaCreacion.ForeColor = Color.FromArgb(35, 56, 85);
            lblFechaCreacion.Location = new Point(596, 46);
            lblFechaCreacion.Name = "lblFechaCreacion";
            lblFechaCreacion.Size = new Size(183, 28);
            lblFechaCreacion.TabIndex = 2;
            lblFechaCreacion.Text = "Fecha de Creación";
            // 
            // txtIdRutina
            // 
            txtIdRutina.BorderStyle = BorderStyle.FixedSingle;
            txtIdRutina.Font = new Font("Segoe UI", 12F);
            txtIdRutina.Location = new Point(48, 77);
            txtIdRutina.Name = "txtIdRutina";
            txtIdRutina.ReadOnly = true;
            txtIdRutina.Size = new Size(498, 34);
            txtIdRutina.TabIndex = 1;
            // 
            // lblIdRutina
            // 
            lblIdRutina.AutoSize = true;
            lblIdRutina.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIdRutina.ForeColor = Color.FromArgb(35, 56, 85);
            lblIdRutina.Location = new Point(48, 46);
            lblIdRutina.Name = "lblIdRutina";
            lblIdRutina.Size = new Size(101, 28);
            lblIdRutina.TabIndex = 0;
            lblIdRutina.Text = "ID Rutina";
            // 
            // panelEjerciciosRutina
            // 
            panelEjerciciosRutina.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEjerciciosRutina.BackColor = Color.White;
            panelEjerciciosRutina.Controls.Add(dgvEjerciciosRutina);
            panelEjerciciosRutina.Controls.Add(lblEjerciciosRutinaTitle);
            panelEjerciciosRutina.Location = new Point(12, 542);
            panelEjerciciosRutina.Name = "panelEjerciciosRutina";
            panelEjerciciosRutina.Size = new Size(1154, 260);
            panelEjerciciosRutina.TabIndex = 2;
            // 
            // dgvEjerciciosRutina
            // 
            dgvEjerciciosRutina.AllowUserToAddRows = false;
            dgvEjerciciosRutina.AllowUserToDeleteRows = false;
            dgvEjerciciosRutina.AllowUserToResizeColumns = false;
            dgvEjerciciosRutina.AllowUserToResizeRows = false;
            dgvEjerciciosRutina.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjerciciosRutina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjerciciosRutina.BackgroundColor = Color.White;
            dgvEjerciciosRutina.BorderStyle = BorderStyle.None;
            dgvEjerciciosRutina.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEjerciciosRutina.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEjerciciosRutina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjerciciosRutina.ColumnHeadersHeight = 58;
            dgvEjerciciosRutina.Columns.AddRange(new DataGridViewColumn[] { colEjercicio, colSeries, colRepeticiones, colTiempo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEjerciciosRutina.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEjerciciosRutina.EnableHeadersVisualStyles = false;
            dgvEjerciciosRutina.GridColor = Color.FromArgb(233, 236, 239);
            dgvEjerciciosRutina.Location = new Point(30, 70);
            dgvEjerciciosRutina.MultiSelect = false;
            dgvEjerciciosRutina.Name = "dgvEjerciciosRutina";
            dgvEjerciciosRutina.ReadOnly = true;
            dgvEjerciciosRutina.RowHeadersVisible = false;
            dgvEjerciciosRutina.RowHeadersWidth = 51;
            dgvEjerciciosRutina.RowTemplate.Height = 52;
            dgvEjerciciosRutina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjerciciosRutina.Size = new Size(1094, 170);
            dgvEjerciciosRutina.TabIndex = 1;
            // 
            // colEjercicio
            // 
            colEjercicio.HeaderText = "Ejercicio";
            colEjercicio.MinimumWidth = 6;
            colEjercicio.Name = "colEjercicio";
            colEjercicio.ReadOnly = true;
            // 
            // colSeries
            // 
            colSeries.HeaderText = "Series";
            colSeries.MinimumWidth = 6;
            colSeries.Name = "colSeries";
            colSeries.ReadOnly = true;
            // 
            // colRepeticiones
            // 
            colRepeticiones.HeaderText = "Repeticiones";
            colRepeticiones.MinimumWidth = 6;
            colRepeticiones.Name = "colRepeticiones";
            colRepeticiones.ReadOnly = true;
            // 
            // colTiempo
            // 
            colTiempo.HeaderText = "Tiempo";
            colTiempo.MinimumWidth = 6;
            colTiempo.Name = "colTiempo";
            colTiempo.ReadOnly = true;
            // 
            // lblEjerciciosRutinaTitle
            // 
            lblEjerciciosRutinaTitle.AutoSize = true;
            lblEjerciciosRutinaTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEjerciciosRutinaTitle.ForeColor = Color.FromArgb(17, 34, 64);
            lblEjerciciosRutinaTitle.Location = new Point(30, 20);
            lblEjerciciosRutinaTitle.Name = "lblEjerciciosRutinaTitle";
            lblEjerciciosRutinaTitle.Size = new Size(325, 41);
            lblEjerciciosRutinaTitle.TabIndex = 0;
            lblEjerciciosRutinaTitle.Text = "Ejercicios de la Rutina";
            // 
            // panelRutinasRegistradas
            // 
            panelRutinasRegistradas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRutinasRegistradas.AutoScroll = true;
            panelRutinasRegistradas.BackColor = Color.White;
            panelRutinasRegistradas.Controls.Add(dgvRutinas);
            panelRutinasRegistradas.Controls.Add(lblRutinasRegistradasTitle);
            panelRutinasRegistradas.Location = new Point(12, 820);
            panelRutinasRegistradas.Name = "panelRutinasRegistradas";
            panelRutinasRegistradas.Size = new Size(1154, 610);
            panelRutinasRegistradas.TabIndex = 3;
            // 
            // dgvRutinas
            // 
            dgvRutinas.AllowUserToAddRows = false;
            dgvRutinas.AllowUserToDeleteRows = false;
            dgvRutinas.AllowUserToResizeColumns = false;
            dgvRutinas.AllowUserToResizeRows = false;
            dgvRutinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRutinas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutinas.BackgroundColor = Color.White;
            dgvRutinas.BorderStyle = BorderStyle.None;
            dgvRutinas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRutinas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRutinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRutinas.ColumnHeadersHeight = 58;
            dgvRutinas.Columns.AddRange(new DataGridViewColumn[] { colRutinaId, colUsuario, colObjetivoGrid, colNivelGrid, colFecha, colDuracion });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRutinas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRutinas.EnableHeadersVisualStyles = false;
            dgvRutinas.GridColor = Color.FromArgb(233, 236, 239);
            dgvRutinas.Location = new Point(30, 70);
            dgvRutinas.MultiSelect = false;
            dgvRutinas.Name = "dgvRutinas";
            dgvRutinas.ReadOnly = true;
            dgvRutinas.RowHeadersVisible = false;
            dgvRutinas.RowHeadersWidth = 51;
            dgvRutinas.RowTemplate.Height = 52;
            dgvRutinas.ScrollBars = ScrollBars.Vertical;
            dgvRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutinas.Size = new Size(1094, 510);
            dgvRutinas.TabIndex = 1;
            // 
            // colRutinaId
            // 
            colRutinaId.FillWeight = 45F;
            colRutinaId.HeaderText = "ID";
            colRutinaId.MinimumWidth = 6;
            colRutinaId.Name = "colRutinaId";
            colRutinaId.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colObjetivoGrid
            // 
            colObjetivoGrid.HeaderText = "Objetivo";
            colObjetivoGrid.MinimumWidth = 6;
            colObjetivoGrid.Name = "colObjetivoGrid";
            colObjetivoGrid.ReadOnly = true;
            // 
            // colNivelGrid
            // 
            colNivelGrid.HeaderText = "Nivel";
            colNivelGrid.MinimumWidth = 6;
            colNivelGrid.Name = "colNivelGrid";
            colNivelGrid.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colDuracion
            // 
            colDuracion.HeaderText = "Duración";
            colDuracion.MinimumWidth = 6;
            colDuracion.Name = "colDuracion";
            colDuracion.ReadOnly = true;
            // 
            // lblRutinasRegistradasTitle
            // 
            lblRutinasRegistradasTitle.AutoSize = true;
            lblRutinasRegistradasTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRutinasRegistradasTitle.ForeColor = Color.FromArgb(17, 34, 64);
            lblRutinasRegistradasTitle.Location = new Point(30, 20);
            lblRutinasRegistradasTitle.Name = "lblRutinasRegistradasTitle";
            lblRutinasRegistradasTitle.Size = new Size(296, 41);
            lblRutinasRegistradasTitle.TabIndex = 0;
            lblRutinasRegistradasTitle.Text = "Rutinas Registradas";
            // 
            // RutinasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1500);
            ClientSize = new Size(1220, 930);
            Controls.Add(panelRutinasRegistradas);
            Controls.Add(panelEjerciciosRutina);
            Controls.Add(panelFormulario);
            Controls.Add(panelHeader);
            Name = "RutinasForm";
            Text = "RutinasForm";
            panelHeader.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelEjerciciosRutina.ResumeLayout(false);
            panelEjerciciosRutina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjerciciosRutina).EndInit();
            panelRutinasRegistradas.ResumeLayout(false);
            panelRutinasRegistradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Button btnInicio;
        private Panel panelFormulario;
        private Button btnGenerarRutina;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtObservaciones;
        private Label lblObservaciones;
        private TextBox txtDuracionSemanas;
        private Label lblDuracionSemanas;
        private ComboBox cmbNivelFisico;
        private Label lblNivelFisico;
        private ComboBox cmbObjetivo;
        private Label lblObjetivo;
        private ComboBox cmbUsuario;
        private Label lblUsuario;
        private TextBox txtFechaCreacion;
        private Label lblFechaCreacion;
        private TextBox txtIdRutina;
        private Label lblIdRutina;
        private Panel panelEjerciciosRutina;
        private DataGridView dgvEjerciciosRutina;
        private DataGridViewTextBoxColumn colEjercicio;
        private DataGridViewTextBoxColumn colSeries;
        private DataGridViewTextBoxColumn colRepeticiones;
        private DataGridViewTextBoxColumn colTiempo;
        private Label lblEjerciciosRutinaTitle;
        private Panel panelRutinasRegistradas;
        private DataGridView dgvRutinas;
        private DataGridViewTextBoxColumn colRutinaId;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colObjetivoGrid;
        private DataGridViewTextBoxColumn colNivelGrid;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colDuracion;
        private Label lblRutinasRegistradasTitle;
    }
}