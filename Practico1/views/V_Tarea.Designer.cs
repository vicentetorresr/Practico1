
namespace Practico1.views
{
    partial class V_Tarea
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.ComboBox cbProyectos;
        private System.Windows.Forms.ComboBox cbUsuarioAsignado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtDescripcion;

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
            components = new System.ComponentModel.Container();
            dgvTareas = new DataGridView();
            btnEliminar_menustrip = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            cbProyectos = new ComboBox();
            cbUsuarioAsignado = new ComboBox();
            lblDescripcion = new Label();
            lblHoras = new Label();
            lblArea = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbArea = new ComboBox();
            txtHoras = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnIngresar = new Button();
            label3 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            btnEliminar_menustrip.SuspendLayout();
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
            dgvTareas.ContextMenuStrip = btnEliminar_menustrip;
            dgvTareas.Location = new Point(34, 254);
            dgvTareas.Margin = new Padding(4);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.ReadOnly = true;
            dgvTareas.RowHeadersWidth = 20;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.Size = new Size(972, 261);
            dgvTareas.TabIndex = 0;
            dgvTareas.CellClick += dgvTareas_CellClick_1;
            // 
            // btnEliminar_menustrip
            // 
            btnEliminar_menustrip.BackColor = Color.Salmon;
            btnEliminar_menustrip.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar_menustrip.ImageScalingSize = new Size(20, 20);
            btnEliminar_menustrip.Items.AddRange(new ToolStripItem[] { eliminarToolStripMenuItem });
            btnEliminar_menustrip.Name = "btnEliminar_menustrip";
            btnEliminar_menustrip.ShowImageMargin = false;
            btnEliminar_menustrip.Size = new Size(165, 26);
            btnEliminar_menustrip.Opening += btnEliminar_menustrip_Opening;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.AutoSize = false;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(158, 22);
            eliminarToolStripMenuItem.Text = "Eliminar esta fila";
            // 
            // cbProyectos
            // 
            cbProyectos.FormattingEnabled = true;
            cbProyectos.Location = new Point(34, 84);
            cbProyectos.Margin = new Padding(4);
            cbProyectos.Name = "cbProyectos";
            cbProyectos.Size = new Size(232, 23);
            cbProyectos.TabIndex = 1;
            cbProyectos.SelectedIndexChanged += cbProyectos_SelectedIndexChanged;
            // 
            // cbUsuarioAsignado
            // 
            cbUsuarioAsignado.FormattingEnabled = true;
            cbUsuarioAsignado.Location = new Point(34, 133);
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
            lblDescripcion.Location = new Point(34, 158);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHoras.Location = new Point(307, 113);
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
            lblArea.Location = new Point(307, 67);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(42, 17);
            lblArea.TabIndex = 11;
            lblArea.Text = "ÁREA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(34, 176);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 23);
            txtDescripcion.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 65);
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
            label2.Location = new Point(34, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 15;
            label2.Text = "USUARIO ASIGNADO";
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Items.AddRange(new object[] { "hardware", "redes" });
            cbArea.Location = new Point(307, 84);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(121, 23);
            cbArea.TabIndex = 18;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(307, 133);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(121, 23);
            txtHoras.TabIndex = 19;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(746, 217);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 33);
            btnActualizar.TabIndex = 57;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Visible = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(883, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 31);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(758, 216);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(117, 34);
            btnIngresar.TabIndex = 55;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 17);
            label3.TabIndex = 9;
            label3.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(34, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(71, 23);
            txtId.TabIndex = 58;
            // 
            // V_Tarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtId);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtHoras);
            Controls.Add(cbArea);
            Controls.Add(dgvTareas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblArea);
            Controls.Add(label3);
            Controls.Add(lblHoras);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cbUsuarioAsignado);
            Controls.Add(cbProyectos);
            Margin = new Padding(4);
            Name = "V_Tarea";
            Size = new Size(1040, 519);
            Load += V_Tarea_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            btnEliminar_menustrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void V_Tarea_Load_1(object sender, EventArgs e)
        {
        }

        private Label label1;
        private Label label2;
        private ComboBox cbArea;
        private TextBox txtHoras;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnIngresar;
        private ContextMenuStrip btnEliminar_menustrip;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Label label3;
        private TextBox txtId;
    }
}
