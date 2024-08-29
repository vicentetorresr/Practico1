namespace Practico1.views
{
    partial class V_Proyecto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnIngresar = new Button();
            dgvLoadTareas = new DataGridView();
            dgvProyecto = new DataGridView();
            btnEliminar_menustrip = new ContextMenuStrip(components);
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtTotalHour = new TextBox();
            txtId = new TextBox();
            txtWorkHours = new TextBox();
            txtNombre = new TextBox();
            lblTareas = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoadTareas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            btnEliminar_menustrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(dgvLoadTareas);
            panel1.Controls.Add(dgvProyecto);
            panel1.Controls.Add(lblTareas);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtTotalHour);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtWorkHours);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 516);
            panel1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveCaption;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(672, 175);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 31);
            btnActualizar.TabIndex = 54;
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
            btnCancelar.Location = new Point(811, 175);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 31);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.LimeGreen;
            btnIngresar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(686, 175);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(117, 31);
            btnIngresar.TabIndex = 52;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // dgvLoadTareas
            // 
            dgvLoadTareas.AllowUserToAddRows = false;
            dgvLoadTareas.AllowUserToDeleteRows = false;
            dgvLoadTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoadTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoadTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadTareas.Dock = DockStyle.Bottom;
            dgvLoadTareas.Location = new Point(0, 445);
            dgvLoadTareas.Name = "dgvLoadTareas";
            dgvLoadTareas.ReadOnly = true;
            dgvLoadTareas.RowHeadersWidth = 51;
            dgvLoadTareas.RowTemplate.Height = 25;
            dgvLoadTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoadTareas.Size = new Size(1035, 69);
            dgvLoadTareas.TabIndex = 51;
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProyecto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.ContextMenuStrip = btnEliminar_menustrip;
            dgvProyecto.Location = new Point(1, 212);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowHeadersWidth = 51;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyecto.Size = new Size(1035, 198);
            dgvProyecto.TabIndex = 51;
            dgvProyecto.CellClick += dgvProyecto_CellClick;
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
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.AutoSize = false;
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(158, 22);
            eliminarToolStripMenuItem.Text = "Eliminar esta fila";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 193);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 44;
            label2.Text = "TABLA DE PROYECTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(208, 123);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 46;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(428, 123);
            label6.Name = "label6";
            label6.Size = new Size(114, 17);
            label6.TabIndex = 47;
            label6.Text = "HORAS TOTALES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(428, 69);
            label5.Name = "label5";
            label5.Size = new Size(140, 17);
            label5.TabIndex = 48;
            label5.Text = "HORAS TRABAJADAS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(45, 21);
            label7.Name = "label7";
            label7.Size = new Size(23, 17);
            label7.TabIndex = 49;
            label7.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 49;
            label1.Text = "NOMBRE: ";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(208, 146);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(201, 41);
            txtDescripcion.TabIndex = 40;
            // 
            // txtTotalHour
            // 
            txtTotalHour.Location = new Point(428, 146);
            txtTotalHour.Margin = new Padding(3, 2, 3, 2);
            txtTotalHour.Name = "txtTotalHour";
            txtTotalHour.Size = new Size(42, 21);
            txtTotalHour.TabIndex = 41;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(45, 42);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 21);
            txtId.TabIndex = 42;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Enabled = false;
            txtWorkHours.Location = new Point(428, 92);
            txtWorkHours.Margin = new Padding(3, 2, 3, 2);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(42, 21);
            txtWorkHours.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 92);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 21);
            txtNombre.TabIndex = 43;
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTareas.Location = new Point(3, 427);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(89, 15);
            lblTareas.TabIndex = 44;
            lblTareas.Text = "TABLA TAREAS";
            // 
            // V_Proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "V_Proyecto";
            Size = new Size(1040, 519);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoadTareas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            btnEliminar_menustrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvProyecto;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtTotalHour;
        private TextBox txtWorkHours;
        private TextBox txtNombre;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnIngresar;
        private Label label7;
        private TextBox txtId;
        private ContextMenuStrip btnEliminar_menustrip;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridView dgvLoadTareas;
        private Label lblTareas;
    }
}
