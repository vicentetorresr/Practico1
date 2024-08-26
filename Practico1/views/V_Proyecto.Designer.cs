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
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Location = new Point(201, 155);
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowTemplate.Height = 25;
            dgvProyecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyecto.Size = new Size(431, 198);
            dgvProyecto.TabIndex = 39;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(282, 106);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 25);
            comboBox1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(716, 338);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 32;
            label2.Text = "Ingreso Proyecto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 106);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 33;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 56);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 34;
            label3.Text = "Descripción";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 59);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 35;
            label6.Text = "Horas Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 22);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 36;
            label5.Text = "Horas trabajadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 37;
            label1.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 47);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 48);
            textBox2.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(590, 54);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(42, 22);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(590, 20);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(42, 22);
            textBox3.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 22);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 22);
            textBox1.TabIndex = 31;
            // 
            // V_Proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvProyecto);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "V_Proyecto";
            Size = new Size(833, 372);
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
