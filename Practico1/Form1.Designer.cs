﻿namespace Practico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnExpadir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnTarea = new Guna.UI2.WinForms.Guna2Button();
            btnProyectos = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnExpadir);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-474, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2178, 64);
            panel1.TabIndex = 16;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top;
            btnSalir.BackColor = Color.Red;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderColor = Color.Black;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 20;
            btnSalir.Location = new Point(1507, 4);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 27);
            btnSalir.TabIndex = 0;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += iconButton1_Click;
            // 
            // btnExpadir
            // 
            btnExpadir.Anchor = AnchorStyles.Top;
            btnExpadir.BackColor = Color.Black;
            btnExpadir.Cursor = Cursors.Hand;
            btnExpadir.IconChar = FontAwesome.Sharp.IconChar.Expand;
            btnExpadir.IconColor = Color.White;
            btnExpadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExpadir.IconSize = 20;
            btnExpadir.Location = new Point(1450, 4);
            btnExpadir.Margin = new Padding(3, 2, 3, 2);
            btnExpadir.Name = "btnExpadir";
            btnExpadir.Size = new Size(50, 27);
            btnExpadir.TabIndex = 0;
            btnExpadir.UseVisualStyleBackColor = false;
            btnExpadir.Click += btnExpadir_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(707, 4);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 5;
            label1.Text = "Practico 1";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Anchor = AnchorStyles.Top;
            guna2CirclePictureBox1.Image = Properties.Resources.logocftBChopped;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(1238, 1);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(215, 63);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(707, 21);
            label7.Name = "label7";
            label7.Size = new Size(338, 37);
            label7.TabIndex = 1;
            label7.Text = "Gestion de Proyectos";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources._4893207;
            pictureBox1.Location = new Point(589, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btnUsuario);
            panel2.Controls.Add(btnTarea);
            panel2.Controls.Add(btnProyectos);
            panel2.Location = new Point(-304, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(2178, 64);
            panel2.TabIndex = 17;
            // 
            // btnUsuario
            // 
            btnUsuario.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnUsuario.CheckedState.CustomBorderColor = Color.Red;
            btnUsuario.CustomBorderColor = Color.Navy;
            btnUsuario.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnUsuario.CustomizableEdges = customizableEdges16;
            btnUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsuario.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnUsuario.Location = new Point(1068, 13);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.ShadowDecoration.CustomizableEdges = customizableEdges17;
            btnUsuario.Size = new Size(318, 45);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "USUARIOS";
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnTarea
            // 
            btnTarea.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnTarea.CheckedState.CustomBorderColor = Color.Red;
            btnTarea.CustomBorderColor = Color.Navy;
            btnTarea.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnTarea.CustomizableEdges = customizableEdges18;
            btnTarea.DisabledState.BorderColor = Color.DarkGray;
            btnTarea.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTarea.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTarea.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTarea.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTarea.ForeColor = Color.White;
            btnTarea.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnTarea.Location = new Point(692, 13);
            btnTarea.Name = "btnTarea";
            btnTarea.ShadowDecoration.CustomizableEdges = customizableEdges19;
            btnTarea.Size = new Size(318, 45);
            btnTarea.TabIndex = 0;
            btnTarea.Text = "TAREAS";
            btnTarea.Click += btnTarea_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnProyectos.Checked = true;
            btnProyectos.CheckedState.CustomBorderColor = Color.Red;
            btnProyectos.CustomBorderColor = Color.Navy;
            btnProyectos.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnProyectos.CustomizableEdges = customizableEdges20;
            btnProyectos.DisabledState.BorderColor = Color.DarkGray;
            btnProyectos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProyectos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProyectos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProyectos.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnProyectos.Location = new Point(316, 13);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.ShadowDecoration.CustomizableEdges = customizableEdges21;
            btnProyectos.Size = new Size(318, 45);
            btnProyectos.TabIndex = 0;
            btnProyectos.Text = "PROYECTOS";
            btnProyectos.Click += btnProyectos_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.ControlDark;
            panelContainer.Location = new Point(10, 161);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1072, 518);
            panelContainer.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1093, 680);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label7;
        private Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnProyectos;
        private Guna.UI2.WinForms.Guna2Button btnUsuario;
        private Guna.UI2.WinForms.Guna2Button btnTarea;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Button btn;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnExpadir;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
