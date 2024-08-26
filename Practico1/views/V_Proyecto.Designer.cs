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
            panel1 = new Panel();
            dgvProyecto = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvProyecto);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 372);
            panel1.TabIndex = 0;
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Location = new Point(45, 153);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyecto.Size = new Size(748, 214);
            dgvProyecto.TabIndex = 51;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(283, 96);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 25);
            comboBox1.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 135);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 44;
            label2.Text = "Tabla de proyectos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 96);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 45;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 46);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 46;
            label3.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 49);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 47;
            label6.Text = "Horas Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 12);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 48;
            label5.Text = "Horas trabajadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 49;
            label1.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 37);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 48);
            textBox2.TabIndex = 40;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(591, 44);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 22);
            textBox4.TabIndex = 41;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(591, 10);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(42, 22);
            textBox3.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 22);
            textBox1.TabIndex = 43;
            // 
            // V_Proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "V_Proyecto";
            Size = new Size(833, 372);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvProyecto;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox1;
    }
}
