﻿namespace Practico1.views
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
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnIngresar = new Button();
            dgvProyecto = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtTotalHour = new TextBox();
            txtWorkHours = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(dgvProyecto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 372);
            panel1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Enabled = false;
            btnActualizar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.Location = new Point(696, 114);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 33);
            btnActualizar.TabIndex = 54;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(602, 114);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 33);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(505, 113);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 34);
            btnIngresar.TabIndex = 52;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
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
            dgvProyecto.CellClick += dgvProyecto_CellClick;
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
            label4.Location = new Point(312, 133);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 45;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 68);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 46;
            label3.Text = "Descripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 68);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 47;
            label6.Text = "Horas Totales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 15);
            label5.Name = "label5";
            label5.Size = new Size(109, 17);
            label5.TabIndex = 48;
            label5.Text = "Horas trabajadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 49;
            label1.Text = "Nombre: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(93, 85);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(201, 41);
            txtDescripcion.TabIndex = 40;
            // 
            // txtTotalHour
            // 
            txtTotalHour.Location = new Point(312, 87);
            txtTotalHour.Margin = new Padding(3, 2, 3, 2);
            txtTotalHour.Name = "txtTotalHour";
            txtTotalHour.Size = new Size(42, 22);
            txtTotalHour.TabIndex = 41;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Location = new Point(312, 34);
            txtWorkHours.Margin = new Padding(3, 2, 3, 2);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(42, 22);
            txtWorkHours.TabIndex = 42;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 31);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 22);
            txtNombre.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 12);
            label7.Name = "label7";
            label7.Size = new Size(20, 17);
            label7.TabIndex = 49;
            label7.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(45, 31);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(42, 22);
            txtId.TabIndex = 42;
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
        private Label label2;
        private Label label4;
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
    }
}
