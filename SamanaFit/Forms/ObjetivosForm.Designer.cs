namespace SamanaFit.Ui.Forms
{
    partial class ObjetivosForm
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
            panelForm = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombreObjetivo = new TextBox();
            lblNombreObjetivo = new Label();
            lblFormTitle = new Label();
            panelRegistros = new Panel();
            dgvObjetivos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombreObjetivo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            lblRegistrosTitle = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjetivos).BeginInit();
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
            panelHeader.Size = new Size(1220, 124);
            panelHeader.TabIndex = 3;
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
            lblHeaderTitle.Text = "Gestión de objetivos";
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
            btnInicio.Location = new Point(1150, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(70, 124);
            btnInicio.TabIndex = 1;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnLimpiar);
            panelForm.Controls.Add(btnEliminar);
            panelForm.Controls.Add(btnEditar);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(txtDescripcion);
            panelForm.Controls.Add(lblDescripcion);
            panelForm.Controls.Add(txtNombreObjetivo);
            panelForm.Controls.Add(lblNombreObjetivo);
            panelForm.Controls.Add(lblFormTitle);
            panelForm.Location = new Point(12, 147);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1196, 470);
            panelForm.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(52, 152, 219);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(900, 408);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(270, 46);
            btnLimpiar.TabIndex = 8;
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
            btnEliminar.Location = new Point(600, 408);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(270, 46);
            btnEliminar.TabIndex = 7;
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
            btnEditar.Location = new Point(312, 408);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(270, 46);
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
            btnGuardar.Location = new Point(24, 408);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(270, 46);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "💾  Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 12F);
            txtDescripcion.Location = new Point(24, 206);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción detallada del objetivo fitness...";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(1146, 170);
            txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(35, 56, 85);
            lblDescripcion.Location = new Point(24, 175);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(123, 28);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción";
            // 
            // txtNombreObjetivo
            // 
            txtNombreObjetivo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreObjetivo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreObjetivo.Font = new Font("Segoe UI", 12F);
            txtNombreObjetivo.Location = new Point(24, 120);
            txtNombreObjetivo.Name = "txtNombreObjetivo";
            txtNombreObjetivo.PlaceholderText = "ej. Pérdida de peso, Masa muscular...";
            txtNombreObjetivo.Size = new Size(200, 34);
            txtNombreObjetivo.TabIndex = 2;
            // 
            // lblNombreObjetivo
            // 
            lblNombreObjetivo.AutoSize = true;
            lblNombreObjetivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombreObjetivo.ForeColor = Color.FromArgb(35, 56, 85);
            lblNombreObjetivo.Location = new Point(24, 89);
            lblNombreObjetivo.Name = "lblNombreObjetivo";
            lblNombreObjetivo.Size = new Size(226, 28);
            lblNombreObjetivo.TabIndex = 1;
            lblNombreObjetivo.Text = "Nombre del Objetivo *";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 18F);
            lblFormTitle.ForeColor = Color.FromArgb(35, 56, 85);
            lblFormTitle.Location = new Point(18, 22);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(337, 41);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Formulario de Objetivos";
            // 
            // panelRegistros
            // 
            panelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRegistros.BackColor = Color.White;
            panelRegistros.Controls.Add(dgvObjetivos);
            panelRegistros.Controls.Add(lblRegistrosTitle);
            panelRegistros.Location = new Point(12, 635);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1196, 408);
            panelRegistros.TabIndex = 5;
            // 
            // dgvObjetivos
            // 
            dgvObjetivos.AllowUserToAddRows = false;
            dgvObjetivos.AllowUserToDeleteRows = false;
            dgvObjetivos.AllowUserToResizeColumns = false;
            dgvObjetivos.AllowUserToResizeRows = false;
            dgvObjetivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvObjetivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvObjetivos.BackgroundColor = Color.White;
            dgvObjetivos.BorderStyle = BorderStyle.None;
            dgvObjetivos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvObjetivos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 249, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvObjetivos.ColumnHeadersHeight = 64;
            dgvObjetivos.Columns.AddRange(new DataGridViewColumn[] { colId, colNombreObjetivo, colDescripcion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 246, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 56, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvObjetivos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvObjetivos.EnableHeadersVisualStyles = false;
            dgvObjetivos.GridColor = Color.FromArgb(233, 236, 239);
            dgvObjetivos.Location = new Point(0, 78);
            dgvObjetivos.MultiSelect = false;
            dgvObjetivos.Name = "dgvObjetivos";
            dgvObjetivos.ReadOnly = true;
            dgvObjetivos.RowHeadersVisible = false;
            dgvObjetivos.RowHeadersWidth = 51;
            dgvObjetivos.RowTemplate.Height = 64;
            dgvObjetivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvObjetivos.Size = new Size(1196, 330);
            dgvObjetivos.TabIndex = 1;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.FillWeight = 40F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombreObjetivo
            // 
            colNombreObjetivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreObjetivo.FillWeight = 90F;
            colNombreObjetivo.HeaderText = "Nombre Objetivo";
            colNombreObjetivo.MinimumWidth = 6;
            colNombreObjetivo.Name = "colNombreObjetivo";
            colNombreObjetivo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.FillWeight = 190F;
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
            lblRegistrosTitle.Location = new Point(24, 22);
            lblRegistrosTitle.Name = "lblRegistrosTitle";
            lblRegistrosTitle.Size = new Size(307, 41);
            lblRegistrosTitle.TabIndex = 0;
            lblRegistrosTitle.Text = "Objetivos Registrados";
            // 
            // ObjetivosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1080);
            ClientSize = new Size(1220, 1055);
            Controls.Add(panelRegistros);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Name = "ObjetivosForm";
            Text = "ObjetivosForm";
            panelHeader.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelRegistros.ResumeLayout(false);
            panelRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjetivos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitle;
        private Button btnInicio;
        private Panel panelForm;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombreObjetivo;
        private Label lblNombreObjetivo;
        private Label lblFormTitle;
        private Panel panelRegistros;
        private DataGridView dgvObjetivos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombreObjetivo;
        private DataGridViewTextBoxColumn colDescripcion;
        private Label lblRegistrosTitle;
    }
}