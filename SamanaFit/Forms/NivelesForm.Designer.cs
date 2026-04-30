namespace SamanaFit.Ui.Forms
{
    partial class NivelesForm
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
            panelRegistro = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtDescripcionNivel = new TextBox();
            lblDescripcionNivel = new Label();
            cmbNombreNivel = new ComboBox();
            lblNombreNivel = new Label();
            lblRegistroTitle = new Label();
            panelRegistros = new Panel();
            dgvNiveles = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombreNivel = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            lblRegistrosTitle = new Label();
            panelHeader.SuspendLayout();
            panelRegistro.SuspendLayout();
            panelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNiveles).BeginInit();
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
            panelHeader.Size = new Size(1069, 124);
            panelHeader.TabIndex = 4;
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
            lblHeaderTitle.Text = "Gestión de niveles";
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
            btnInicio.Location = new Point(999, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(70, 124);
            btnInicio.TabIndex = 1;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelRegistro
            // 
            panelRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistro.BackColor = Color.White;
            panelRegistro.Controls.Add(btnLimpiar);
            panelRegistro.Controls.Add(btnEliminar);
            panelRegistro.Controls.Add(btnEditar);
            panelRegistro.Controls.Add(btnGuardar);
            panelRegistro.Controls.Add(txtDescripcionNivel);
            panelRegistro.Controls.Add(lblDescripcionNivel);
            panelRegistro.Controls.Add(cmbNombreNivel);
            panelRegistro.Controls.Add(lblNombreNivel);
            panelRegistro.Controls.Add(lblRegistroTitle);
            panelRegistro.Location = new Point(12, 142);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(1045, 416);
            panelRegistro.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 126, 238);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(462, 340);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 46);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "🔄  Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(241, 148, 157);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(314, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 46);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "🗑️  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(185, 134, 255);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(166, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 46);
            btnEditar.TabIndex = 6;
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
            btnGuardar.Location = new Point(18, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 46);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcionNivel
            // 
            txtDescripcionNivel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcionNivel.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionNivel.Font = new Font("Segoe UI", 12F);
            txtDescripcionNivel.Location = new Point(18, 206);
            txtDescripcionNivel.Multiline = true;
            txtDescripcionNivel.Name = "txtDescripcionNivel";
            txtDescripcionNivel.PlaceholderText = "Ingrese una descripción detallada del nivel";
            txtDescripcionNivel.Size = new Size(1875, 104);
            txtDescripcionNivel.TabIndex = 4;
            // 
            // lblDescripcionNivel
            // 
            lblDescripcionNivel.AutoSize = true;
            lblDescripcionNivel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescripcionNivel.ForeColor = Color.FromArgb(17, 34, 64);
            lblDescripcionNivel.Location = new Point(18, 175);
            lblDescripcionNivel.Name = "lblDescripcionNivel";
            lblDescripcionNivel.Size = new Size(123, 28);
            lblDescripcionNivel.TabIndex = 3;
            lblDescripcionNivel.Text = "Descripción";
            // 
            // cmbNombreNivel
            // 
            cmbNombreNivel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbNombreNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNombreNivel.Font = new Font("Segoe UI", 12F);
            cmbNombreNivel.FormattingEnabled = true;
            cmbNombreNivel.Items.AddRange(new object[] { "Seleccione un nivel", "Principiante", "Intermedio", "Avanzado" });
            cmbNombreNivel.Location = new Point(18, 120);
            cmbNombreNivel.Name = "cmbNombreNivel";
            cmbNombreNivel.Size = new Size(1875, 36);
            cmbNombreNivel.TabIndex = 2;
            // 
            // lblNombreNivel
            // 
            lblNombreNivel.AutoSize = true;
            lblNombreNivel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreNivel.ForeColor = Color.FromArgb(17, 34, 64);
            lblNombreNivel.Location = new Point(18, 89);
            lblNombreNivel.Name = "lblNombreNivel";
            lblNombreNivel.Size = new Size(180, 28);
            lblNombreNivel.TabIndex = 1;
            lblNombreNivel.Text = "Nombre del Nivel";
            // 
            // lblRegistroTitle
            // 
            lblRegistroTitle.AutoSize = true;
            lblRegistroTitle.Font = new Font("Segoe UI", 18F);
            lblRegistroTitle.ForeColor = Color.FromArgb(17, 34, 64);
            lblRegistroTitle.Location = new Point(18, 22);
            lblRegistroTitle.Name = "lblRegistroTitle";
            lblRegistroTitle.Size = new Size(303, 41);
            lblRegistroTitle.TabIndex = 0;
            lblRegistroTitle.Text = "Registrar Nuevo Nivel";
            // 
            // panelRegistros
            // 
            panelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistros.BackColor = Color.White;
            panelRegistros.Controls.Add(dgvNiveles);
            panelRegistros.Controls.Add(lblRegistrosTitle);
            panelRegistros.Location = new Point(12, 580);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1045, 358);
            panelRegistros.TabIndex = 6;
            // 
            // dgvNiveles
            // 
            dgvNiveles.AllowUserToAddRows = false;
            dgvNiveles.AllowUserToDeleteRows = false;
            dgvNiveles.AllowUserToResizeColumns = false;
            dgvNiveles.AllowUserToResizeRows = false;
            dgvNiveles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNiveles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNiveles.BackgroundColor = Color.White;
            dgvNiveles.BorderStyle = BorderStyle.None;
            dgvNiveles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNiveles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNiveles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNiveles.ColumnHeadersHeight = 58;
            dgvNiveles.Columns.AddRange(new DataGridViewColumn[] { colId, colNombreNivel, colDescripcion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNiveles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNiveles.EnableHeadersVisualStyles = false;
            dgvNiveles.GridColor = Color.FromArgb(233, 236, 239);
            dgvNiveles.Location = new Point(0, 74);
            dgvNiveles.MultiSelect = false;
            dgvNiveles.Name = "dgvNiveles";
            dgvNiveles.ReadOnly = true;
            dgvNiveles.RowHeadersVisible = false;
            dgvNiveles.RowHeadersWidth = 51;
            dgvNiveles.RowTemplate.Height = 52;
            dgvNiveles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNiveles.Size = new Size(1045, 284);
            dgvNiveles.TabIndex = 1;
            // 
            // colId
            // 
            colId.FillWeight = 35F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombreNivel
            // 
            colNombreNivel.FillWeight = 90F;
            colNombreNivel.HeaderText = "Nombre del Nivel";
            colNombreNivel.MinimumWidth = 6;
            colNombreNivel.Name = "colNombreNivel";
            colNombreNivel.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.FillWeight = 200F;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // lblRegistrosTitle
            // 
            lblRegistrosTitle.AutoSize = true;
            lblRegistrosTitle.Font = new Font("Segoe UI", 18F);
            lblRegistrosTitle.ForeColor = Color.FromArgb(35, 56, 85);
            lblRegistrosTitle.Location = new Point(24, 20);
            lblRegistrosTitle.Name = "lblRegistrosTitle";
            lblRegistrosTitle.Size = new Size(276, 41);
            lblRegistrosTitle.TabIndex = 0;
            lblRegistrosTitle.Text = "Niveles Registrados";
            // 
            // NivelesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 950);
            ClientSize = new Size(1090, 930);
            Controls.Add(panelRegistros);
            Controls.Add(panelRegistro);
            Controls.Add(panelHeader);
            Name = "NivelesForm";
            Text = "NivelesForm";
            panelHeader.ResumeLayout(false);
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNiveles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Button btnInicio;
        private Panel panelRegistro;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtDescripcionNivel;
        private Label lblDescripcionNivel;
        private ComboBox cmbNombreNivel;
        private Label lblNombreNivel;
        private Label lblRegistroTitle;
        private Panel panelRegistros;
        private DataGridView dgvNiveles;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombreNivel;
        private DataGridViewTextBoxColumn colDescripcion;
        private Label lblRegistrosTitle;
    }
}