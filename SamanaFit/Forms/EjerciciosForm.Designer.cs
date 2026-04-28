namespace SamanaFit.Ui.Forms
{
    partial class EjerciciosForm
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
            panelFormulario = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtDuracion = new TextBox();
            lblDuracion = new Label();
            txtCalorias = new TextBox();
            lblCalorias = new Label();
            cmbTipoEjercicio = new ComboBox();
            lblTipoEjercicio = new Label();
            cmbNivelFisico = new ComboBox();
            lblNivelFisico = new Label();
            txtNombreEjercicio = new TextBox();
            lblNombreEjercicio = new Label();
            lblFormularioTitle = new Label();
            panelRegistros = new Panel();
            dgvEjercicios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colDuracion = new DataGridViewTextBoxColumn();
            colCalorias = new DataGridViewTextBoxColumn();
            colDescripcionGrid = new DataGridViewTextBoxColumn();
            lblRegistrosTitle = new Label();
            panelHeader.SuspendLayout();
            panelFormulario.SuspendLayout();
            panelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1094, 124);
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
            lblHeaderTitle.Text = "Gestión de ejercicios";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.BackColor = Color.White;
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnEditar);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(txtDescripcion);
            panelFormulario.Controls.Add(lblDescripcion);
            panelFormulario.Controls.Add(txtDuracion);
            panelFormulario.Controls.Add(lblDuracion);
            panelFormulario.Controls.Add(txtCalorias);
            panelFormulario.Controls.Add(lblCalorias);
            panelFormulario.Controls.Add(cmbTipoEjercicio);
            panelFormulario.Controls.Add(lblTipoEjercicio);
            panelFormulario.Controls.Add(cmbNivelFisico);
            panelFormulario.Controls.Add(lblNivelFisico);
            panelFormulario.Controls.Add(txtNombreEjercicio);
            panelFormulario.Controls.Add(lblNombreEjercicio);
            panelFormulario.Controls.Add(lblFormularioTitle);
            panelFormulario.Location = new Point(12, 147);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1070, 538);
            panelFormulario.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 126, 238);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(558, 456);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 52);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "🔄  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(241, 69, 69);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(382, 456);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 52);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 67, 232);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(206, 456);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(170, 52);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(227, 0, 82);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(30, 456);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 52);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "➕  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(538, 280);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del ejercicio...";
            txtDescripcion.Size = new Size(502, 108);
            txtDescripcion.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(35, 56, 85);
            lblDescripcion.Location = new Point(538, 249);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(123, 28);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDuracion
            // 
            txtDuracion.BorderStyle = BorderStyle.FixedSingle;
            txtDuracion.Font = new Font("Segoe UI", 12F);
            txtDuracion.Location = new Point(30, 280);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.PlaceholderText = "30";
            txtDuracion.Size = new Size(488, 34);
            txtDuracion.TabIndex = 10;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDuracion.ForeColor = Color.FromArgb(35, 56, 85);
            lblDuracion.Location = new Point(30, 249);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(205, 28);
            lblDuracion.TabIndex = 9;
            lblDuracion.Text = "Duración (Minutos) *";
            // 
            // txtCalorias
            // 
            txtCalorias.BorderStyle = BorderStyle.FixedSingle;
            txtCalorias.Font = new Font("Segoe UI", 12F);
            txtCalorias.Location = new Point(538, 190);
            txtCalorias.Name = "txtCalorias";
            txtCalorias.PlaceholderText = "Ej: 250";
            txtCalorias.Size = new Size(502, 34);
            txtCalorias.TabIndex = 8;
            // 
            // lblCalorias
            // 
            lblCalorias.AutoSize = true;
            lblCalorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCalorias.ForeColor = Color.FromArgb(35, 56, 85);
            lblCalorias.Location = new Point(538, 159);
            lblCalorias.Name = "lblCalorias";
            lblCalorias.Size = new Size(178, 28);
            lblCalorias.TabIndex = 7;
            lblCalorias.Text = "Calorías Quemadas";
            // 
            // cmbTipoEjercicio
            // 
            cmbTipoEjercicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEjercicio.Font = new Font("Segoe UI", 12F);
            cmbTipoEjercicio.FormattingEnabled = true;
            cmbTipoEjercicio.Items.AddRange(new object[] { "Cardio", "Fuerza", "Flexibilidad", "Resistencia" });
            cmbTipoEjercicio.Location = new Point(30, 190);
            cmbTipoEjercicio.Name = "cmbTipoEjercicio";
            cmbTipoEjercicio.Size = new Size(488, 36);
            cmbTipoEjercicio.TabIndex = 6;
            // 
            // lblTipoEjercicio
            // 
            lblTipoEjercicio.AutoSize = true;
            lblTipoEjercicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTipoEjercicio.ForeColor = Color.FromArgb(35, 56, 85);
            lblTipoEjercicio.Location = new Point(30, 159);
            lblTipoEjercicio.Name = "lblTipoEjercicio";
            lblTipoEjercicio.Size = new Size(179, 28);
            lblTipoEjercicio.TabIndex = 5;
            lblTipoEjercicio.Text = "Tipo de Ejercicio *";
            // 
            // cmbNivelFisico
            // 
            cmbNivelFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelFisico.Font = new Font("Segoe UI", 12F);
            cmbNivelFisico.FormattingEnabled = true;
            cmbNivelFisico.Items.AddRange(new object[] { "Principiante", "Intermedio", "Avanzado" });
            cmbNivelFisico.Location = new Point(538, 100);
            cmbNivelFisico.Name = "cmbNivelFisico";
            cmbNivelFisico.Size = new Size(502, 36);
            cmbNivelFisico.TabIndex = 4;
            // 
            // lblNivelFisico
            // 
            lblNivelFisico.AutoSize = true;
            lblNivelFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNivelFisico.ForeColor = Color.FromArgb(35, 56, 85);
            lblNivelFisico.Location = new Point(538, 69);
            lblNivelFisico.Name = "lblNivelFisico";
            lblNivelFisico.Size = new Size(132, 28);
            lblNivelFisico.TabIndex = 3;
            lblNivelFisico.Text = "Nivel Físico *";
            // 
            // txtNombreEjercicio
            // 
            txtNombreEjercicio.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEjercicio.Font = new Font("Segoe UI", 12F);
            txtNombreEjercicio.Location = new Point(30, 100);
            txtNombreEjercicio.Name = "txtNombreEjercicio";
            txtNombreEjercicio.PlaceholderText = "Ej: Sentadillas";
            txtNombreEjercicio.Size = new Size(488, 34);
            txtNombreEjercicio.TabIndex = 2;
            // 
            // lblNombreEjercicio
            // 
            lblNombreEjercicio.AutoSize = true;
            lblNombreEjercicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreEjercicio.ForeColor = Color.FromArgb(35, 56, 85);
            lblNombreEjercicio.Location = new Point(30, 69);
            lblNombreEjercicio.Name = "lblNombreEjercicio";
            lblNombreEjercicio.Size = new Size(194, 28);
            lblNombreEjercicio.TabIndex = 1;
            lblNombreEjercicio.Text = "Nombre del Ejercicio *";
            // 
            // lblFormularioTitle
            // 
            lblFormularioTitle.AutoSize = true;
            lblFormularioTitle.Font = new Font("Segoe UI", 18F);
            lblFormularioTitle.ForeColor = Color.FromArgb(35, 56, 85);
            lblFormularioTitle.Location = new Point(30, 20);
            lblFormularioTitle.Name = "lblFormularioTitle";
            lblFormularioTitle.Size = new Size(357, 41);
            lblFormularioTitle.TabIndex = 0;
            lblFormularioTitle.Text = "Información del Ejercicio";
            // 
            // panelRegistros
            // 
            panelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistros.BackColor = Color.White;
            panelRegistros.Controls.Add(dgvEjercicios);
            panelRegistros.Controls.Add(lblRegistrosTitle);
            panelRegistros.Location = new Point(12, 701);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1070, 305);
            panelRegistros.TabIndex = 7;
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.AllowUserToAddRows = false;
            dgvEjercicios.AllowUserToDeleteRows = false;
            dgvEjercicios.AllowUserToResizeColumns = false;
            dgvEjercicios.AllowUserToResizeRows = false;
            dgvEjercicios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEjercicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEjercicios.BackgroundColor = Color.White;
            dgvEjercicios.BorderStyle = BorderStyle.None;
            dgvEjercicios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEjercicios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEjercicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEjercicios.ColumnHeadersHeight = 58;
            dgvEjercicios.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colTipo, colNivel, colDuracion, colCalorias, colDescripcionGrid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEjercicios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEjercicios.EnableHeadersVisualStyles = false;
            dgvEjercicios.GridColor = Color.FromArgb(233, 236, 239);
            dgvEjercicios.Location = new Point(0, 75);
            dgvEjercicios.MultiSelect = false;
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.ReadOnly = true;
            dgvEjercicios.RowHeadersVisible = false;
            dgvEjercicios.RowHeadersWidth = 51;
            dgvEjercicios.RowTemplate.Height = 52;
            dgvEjercicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEjercicios.Size = new Size(1070, 230);
            dgvEjercicios.TabIndex = 1;
            // 
            // colId
            // 
            colId.FillWeight = 30F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.FillWeight = 110F;
            colNombre.HeaderText = "NOMBRE";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.FillWeight = 85F;
            colTipo.HeaderText = "TIPO";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.FillWeight = 95F;
            colNivel.HeaderText = "NIVEL";
            colNivel.MinimumWidth = 6;
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colDuracion
            // 
            colDuracion.FillWeight = 75F;
            colDuracion.HeaderText = "DURACIÓN (MIN)";
            colDuracion.MinimumWidth = 6;
            colDuracion.Name = "colDuracion";
            colDuracion.ReadOnly = true;
            // 
            // colCalorias
            // 
            colCalorias.FillWeight = 75F;
            colCalorias.HeaderText = "CALORÍAS";
            colCalorias.MinimumWidth = 6;
            colCalorias.Name = "colCalorias";
            colCalorias.ReadOnly = true;
            // 
            // colDescripcionGrid
            // 
            colDescripcionGrid.FillWeight = 150F;
            colDescripcionGrid.HeaderText = "DESCRIPCIÓN";
            colDescripcionGrid.MinimumWidth = 6;
            colDescripcionGrid.Name = "colDescripcionGrid";
            colDescripcionGrid.ReadOnly = true;
            // 
            // lblRegistrosTitle
            // 
            lblRegistrosTitle.AutoSize = true;
            lblRegistrosTitle.Font = new Font("Segoe UI", 18F);
            lblRegistrosTitle.ForeColor = Color.FromArgb(35, 56, 85);
            lblRegistrosTitle.Location = new Point(24, 20);
            lblRegistrosTitle.Name = "lblRegistrosTitle";
            lblRegistrosTitle.Size = new Size(317, 41);
            lblRegistrosTitle.TabIndex = 0;
            lblRegistrosTitle.Text = "Ejercicios Registrados";
            // 
            // EjerciciosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 1020);
            Controls.Add(panelRegistros);
            Controls.Add(panelFormulario);
            Controls.Add(panelHeader);
            Name = "EjerciciosForm";
            Text = "EjerciciosForm";
            panelHeader.ResumeLayout(false);
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Panel panelFormulario;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtDuracion;
        private Label lblDuracion;
        private TextBox txtCalorias;
        private Label lblCalorias;
        private ComboBox cmbTipoEjercicio;
        private Label lblTipoEjercicio;
        private ComboBox cmbNivelFisico;
        private Label lblNivelFisico;
        private TextBox txtNombreEjercicio;
        private Label lblNombreEjercicio;
        private Label lblFormularioTitle;
        private Panel panelRegistros;
        private DataGridView dgvEjercicios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colDuracion;
        private DataGridViewTextBoxColumn colCalorias;
        private DataGridViewTextBoxColumn colDescripcionGrid;
        private Label lblRegistrosTitle;
    }
}