
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
            dgvTareas.Anchor = AnchorStyles.Bottom;
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(39, 339);
            dgvTareas.Margin = new Padding(4, 5, 4, 5);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 20;
            dgvTareas.Size = new Size(1111, 348);
            dgvTareas.TabIndex = 0;
            dgvTareas.CellContentClick += dgvTareas_CellContentClick;
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(40, 32);
            cbProyectos.Margin = new Padding(4, 5, 4, 5);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(265, 28);
            cbProyectos.TabIndex = 1;
            cbProyectos.SelectedIndexChanged += cbProyectos_SelectedIndexChanged;
            // 
            // cbUsuarioAsignado
            // 
            cbUsuarioAsignado.FormattingEnabled = true;
            cbUsuarioAsignado.Location = new Point(40, 97);
            cbUsuarioAsignado.Margin = new Padding(4, 5, 4, 5);
            cbUsuarioAsignado.Name = "cbUsuarioAsignado";
            cbUsuarioAsignado.Size = new Size(265, 28);
            cbUsuarioAsignado.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(40, 130);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(116, 20);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "DESCRIPCIÓN";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaInicio.Location = new Point(351, 8);
            lblFechaInicio.Margin = new Padding(4, 0, 4, 0);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(148, 21);
            lblFechaInicio.TabIndex = 5;
            lblFechaInicio.Text = "FECHA DE INICIO";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(351, 130);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(74, 21);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "ESTADO";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoras.Location = new Point(40, 196);
            lblHoras.Margin = new Padding(4, 0, 4, 0);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(68, 21);
            lblHoras.TabIndex = 9;
            lblHoras.Text = "HORAS";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblArea.Location = new Point(351, 73);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(54, 21);
            lblArea.TabIndex = 11;
            lblArea.Text = "ÁREA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(40, 155);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 27);
            txtDescripcion.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(351, 33);
            dtpFechaInicio.Margin = new Padding(4, 5, 4, 5);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(265, 27);
            dtpFechaInicio.TabIndex = 6;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Pendiente", "En progreso", "Completada" });
            cbEstado.Location = new Point(351, 155);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(265, 28);
            cbEstado.TabIndex = 8;
            // 
            // nudHoras
            // 
            nudHoras.Location = new Point(40, 221);
            nudHoras.Margin = new Padding(4, 5, 4, 5);
            nudHoras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudHoras.Name = "nudHoras";
            nudHoras.Size = new Size(267, 27);
            nudHoras.TabIndex = 10;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(351, 98);
            txtArea.Margin = new Padding(4, 5, 4, 5);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(265, 27);
            txtArea.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(386, 213);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(230, 35);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 14;
            label1.Text = "PROYECTO ASIGNADO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 71);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 21);
            label2.TabIndex = 15;
            label2.Text = "USUARIO ASIGNADO";
            // 
            // V_Tarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "V_Tarea";
            Size = new Size(1188, 692);
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
