
namespace Practico1.views
{
    partial class V_Tarea
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.ComboBox cbProyectos;
        private System.Windows.Forms.ComboBox cbUsuarioAsignado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTareas = new DataGridView();
            cbProyectos = new ComboBox();
            cbUsuarioAsignado = new ComboBox();
            lblDescripcion = new Label();
            lblFechaInicio = new Label();
            lblEstado = new Label();
            lblHoras = new Label();
            lblArea = new Label();
            txtDescripcion = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            cbEstado = new ComboBox();
            nudHoras = new NumericUpDown();
            txtArea = new TextBox();
            btnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
            SuspendLayout();
            // 
            // dgvTareas
            // 
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.Anchor = AnchorStyles.Bottom;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(34, 254);
            dgvTareas.Margin = new Padding(4);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 20;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(972, 261);
            dgvTareas.TabIndex = 0;
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(35, 24);
            cbProyectos.Margin = new Padding(4);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(232, 23);
            cbProyectos.TabIndex = 1;
            cbProyectos.SelectedIndexChanged += cbProyectos_SelectedIndexChanged;
            // 
            // cbUsuarioAsignado
            // 
            cbUsuarioAsignado.FormattingEnabled = true;
            cbUsuarioAsignado.Location = new Point(35, 73);
            cbUsuarioAsignado.Margin = new Padding(4);
            cbUsuarioAsignado.Name = "cbUsuarioAsignado";
            cbUsuarioAsignado.Size = new Size(232, 23);
            cbUsuarioAsignado.TabIndex = 2;
            cbUsuarioAsignado.SelectedIndexChanged += cbUsuarioAsignado_SelectedIndexChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(35, 98);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaInicio.Location = new Point(307, 6);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(117, 17);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "FECHA DE INICIO";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(307, 98);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 17);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "ESTADO";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoras.Location = new Point(35, 147);
            lblHoras.Margin = new Padding(4, 0, 4, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(53, 17);
            lblHoras.TabIndex = 9;
            lblHoras.Text = "HORAS";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblArea.Location = new Point(307, 55);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(42, 17);
            lblArea.TabIndex = 11;
            lblArea.Text = "ÁREA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(35, 116);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(307, 25);
            dtpFechaInicio.Margin = new Padding(4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(232, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente", "En progreso", "Completada" });
            cbEstado.Location = new Point(307, 116);
            cbEstado.Margin = new Padding(4);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(232, 23);
            cbEstado.TabIndex = 8;
            // 
            // nudHoras
            // 
            nudHoras.Location = new Point(35, 166);
            nudHoras.Margin = new Padding(4);
            nudHoras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudHoras.Name = "nudHoras";
            nudHoras.Size = new Size(234, 23);
            nudHoras.TabIndex = 10;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(307, 74);
            txtArea.Margin = new Padding(4);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(232, 23);
            txtArea.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(338, 160);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(201, 26);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 14;
            label1.Text = "PROYECTO ASIGNADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 15;
            label2.Text = "USUARIO ASIGNADO";
            // 
            // V_Tarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTareas);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(nudHoras);
            Controls.Add(lblHoras);
            Controls.Add(cbEstado);
            Controls.Add(lblEstado);
            Controls.Add(dtpFechaInicio);
            Controls.Add(lblFechaInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cbUsuarioAsignado);
            Controls.Add(cbProyectos);
            Margin = new Padding(4);
            Name = "V_Tarea";
            Size = new Size(1040, 519);
            Load += V_Tarea_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void V_Tarea_Load_1(object sender, EventArgs e)
        {
        }

        private Label label1;
        private Label label2;
    }
}
