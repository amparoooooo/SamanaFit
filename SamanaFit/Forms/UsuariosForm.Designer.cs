namespace SamanaFit.Ui.Forms
{
    partial class UsuariosForm
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblHeaderTitle = new Label();
            btnNotificaciones = new Button();
            btnAdministrador = new Button();
            panelForm = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            dtpFechaRegistro = new DateTimePicker();
            lblFechaRegistro = new Label();
            cmbObjetivo = new ComboBox();
            lblObjetivo = new Label();
            cmbNivelFisico = new ComboBox();
            lblNivelFisico = new Label();
            txtAltura = new TextBox();
            lblAltura = new Label();
            txtPeso = new TextBox();
            lblPeso = new Label();
            cmbSexo = new ComboBox();
            lblSexo = new Label();
            txtEdad = new TextBox();
            lblEdad = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colEdad = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            colNivel = new DataGridViewTextBoxColumn();
            colObjetivo = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Controls.Add(btnNotificaciones);
            panelHeader.Controls.Add(btnAdministrador);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1220, 124);
            panelHeader.TabIndex = 2;
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
            lblHeaderTitle.Text = "Gestión de usuarios";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNotificaciones
            // 
            btnNotificaciones.Dock = DockStyle.Right;
            btnNotificaciones.FlatAppearance.BorderSize = 0;
            btnNotificaciones.FlatStyle = FlatStyle.Flat;
            btnNotificaciones.Font = new Font("Segoe UI", 14F);
            btnNotificaciones.ForeColor = Color.FromArgb(64, 64, 64);
            btnNotificaciones.Image = Properties.Resources.bell;
            btnNotificaciones.Location = new Point(950, 0);
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
            btnAdministrador.Image = Properties.Resources.circle_user;
            btnAdministrador.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdministrador.Location = new Point(1020, 0);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(200, 124);
            btnAdministrador.TabIndex = 1;
            btnAdministrador.Text = " Administrador";
            btnAdministrador.Click += btnAdministrador_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnLimpiar);
            panelForm.Controls.Add(btnEliminar);
            panelForm.Controls.Add(btnEditar);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(dtpFechaRegistro);
            panelForm.Controls.Add(lblFechaRegistro);
            panelForm.Controls.Add(cmbObjetivo);
            panelForm.Controls.Add(lblObjetivo);
            panelForm.Controls.Add(cmbNivelFisico);
            panelForm.Controls.Add(lblNivelFisico);
            panelForm.Controls.Add(txtAltura);
            panelForm.Controls.Add(lblAltura);
            panelForm.Controls.Add(txtPeso);
            panelForm.Controls.Add(lblPeso);
            panelForm.Controls.Add(cmbSexo);
            panelForm.Controls.Add(lblSexo);
            panelForm.Controls.Add(txtEdad);
            panelForm.Controls.Add(lblEdad);
            panelForm.Controls.Add(txtApellido);
            panelForm.Controls.Add(lblApellido);
            panelForm.Controls.Add(txtNombre);
            panelForm.Controls.Add(lblNombre);
            panelForm.Location = new Point(12, 147);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1187, 470);
            panelForm.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 152, 219);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(894, 418);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(260, 46);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "🔄  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(584, 418);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(260, 46);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(155, 89, 182);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(304, 418);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(260, 46);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "✏️  Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(227, 0, 82);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(24, 418);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(260, 46);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Font = new Font("Segoe UI", 12F);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(24, 346);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(1130, 34);
            dtpFechaRegistro.TabIndex = 17;
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFechaRegistro.ForeColor = Color.FromArgb(35, 56, 85);
            lblFechaRegistro.Location = new Point(24, 316);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(180, 28);
            lblFechaRegistro.TabIndex = 16;
            lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // cmbObjetivo
            // 
            cmbObjetivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObjetivo.Font = new Font("Segoe UI", 12F);
            cmbObjetivo.FormattingEnabled = true;
            cmbObjetivo.Location = new Point(604, 270);
            cmbObjetivo.Name = "cmbObjetivo";
            cmbObjetivo.Size = new Size(550, 36);
            cmbObjetivo.TabIndex = 15;
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblObjetivo.ForeColor = Color.FromArgb(35, 56, 85);
            lblObjetivo.Location = new Point(604, 240);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(93, 28);
            lblObjetivo.TabIndex = 14;
            lblObjetivo.Text = "Objetivo";
            // 
            // cmbNivelFisico
            // 
            cmbNivelFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNivelFisico.Font = new Font("Segoe UI", 12F);
            cmbNivelFisico.FormattingEnabled = true;
            cmbNivelFisico.Location = new Point(24, 270);
            cmbNivelFisico.Name = "cmbNivelFisico";
            cmbNivelFisico.Size = new Size(550, 36);
            cmbNivelFisico.TabIndex = 13;
            // 
            // lblNivelFisico
            // 
            lblNivelFisico.AutoSize = true;
            lblNivelFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNivelFisico.ForeColor = Color.FromArgb(35, 56, 85);
            lblNivelFisico.Location = new Point(24, 240);
            lblNivelFisico.Name = "lblNivelFisico";
            lblNivelFisico.Size = new Size(121, 28);
            lblNivelFisico.TabIndex = 12;
            lblNivelFisico.Text = "Nivel Físico";
            // 
            // txtAltura
            // 
            txtAltura.BorderStyle = BorderStyle.FixedSingle;
            txtAltura.Font = new Font("Segoe UI", 12F);
            txtAltura.Location = new Point(604, 194);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Altura en centímetros";
            txtAltura.Size = new Size(550, 34);
            txtAltura.TabIndex = 11;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAltura.ForeColor = Color.FromArgb(35, 56, 85);
            lblAltura.Location = new Point(604, 164);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(119, 28);
            lblAltura.TabIndex = 10;
            lblAltura.Text = "Altura (cm)";
            // 
            // txtPeso
            // 
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(24, 194);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso en libras";
            txtPeso.Size = new Size(550, 34);
            txtPeso.TabIndex = 9;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPeso.ForeColor = Color.FromArgb(35, 56, 85);
            lblPeso.Location = new Point(24, 164);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(93, 28);
            lblPeso.TabIndex = 8;
            lblPeso.Text = "Peso (lb)";
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.Font = new Font("Segoe UI", 12F);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Seleccione", "Masculino", "Femenino" });
            cmbSexo.Location = new Point(604, 118);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(550, 36);
            cmbSexo.TabIndex = 7;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSexo.ForeColor = Color.FromArgb(35, 56, 85);
            lblSexo.Location = new Point(604, 88);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(57, 28);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo";
            // 
            // txtEdad
            // 
            txtEdad.BorderStyle = BorderStyle.FixedSingle;
            txtEdad.Font = new Font("Segoe UI", 12F);
            txtEdad.Location = new Point(24, 118);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Años";
            txtEdad.Size = new Size(550, 34);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEdad.ForeColor = Color.FromArgb(35, 56, 85);
            lblEdad.Location = new Point(24, 88);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(58, 28);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(604, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese el apellido";
            txtApellido.Size = new Size(550, 34);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(35, 56, 85);
            lblApellido.Location = new Point(604, 12);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(91, 28);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(24, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese el nombre";
            txtNombre.Size = new Size(550, 34);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(35, 56, 85);
            lblNombre.Location = new Point(24, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(227, 0, 82);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(227, 0, 82);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvUsuarios.ColumnHeadersHeight = 48;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colApellido, colEdad, colSexo, colNivel, colObjetivo });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle11;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(224, 224, 224);
            dgvUsuarios.Location = new Point(12, 623);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(248, 249, 252);
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvUsuarios.RowTemplate.Height = 44;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1187, 173);
            dgvUsuarios.TabIndex = 4;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.ReadOnly = true;
            // 
            // colEdad
            // 
            colEdad.HeaderText = "Edad";
            colEdad.MinimumWidth = 6;
            colEdad.Name = "colEdad";
            colEdad.ReadOnly = true;
            // 
            // colSexo
            // 
            colSexo.HeaderText = "Sexo";
            colSexo.MinimumWidth = 6;
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            // 
            // colNivel
            // 
            colNivel.HeaderText = "Nivel";
            colNivel.MinimumWidth = 6;
            colNivel.Name = "colNivel";
            colNivel.ReadOnly = true;
            // 
            // colObjetivo
            // 
            colObjetivo.HeaderText = "Objetivo";
            colObjetivo.MinimumWidth = 6;
            colObjetivo.Name = "colObjetivo";
            colObjetivo.ReadOnly = true;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 808);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Button btnNotificaciones;
        private Button btnAdministrador;
        private Panel panelForm;
        private DataGridView dgvUsuarios;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEdad;
        private TextBox txtEdad;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblAltura;
        private TextBox txtAltura;
        private Label lblNivelFisico;
        private ComboBox cmbNivelFisico;
        private Label lblObjetivo;
        private ComboBox cmbObjetivo;
        private Label lblFechaRegistro;
        private DateTimePicker dtpFechaRegistro;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colEdad;
        private DataGridViewTextBoxColumn colSexo;
        private DataGridViewTextBoxColumn colNivel;
        private DataGridViewTextBoxColumn colObjetivo;
    }
}