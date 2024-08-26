namespace Practico1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnUsuario = new Guna.UI2.WinForms.Guna2Button();
            btnTarea = new Guna.UI2.WinForms.Guna2Button();
            btnProyectos = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 63);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(93, 29);
            label7.Name = "label7";
            label7.Size = new Size(390, 28);
            label7.TabIndex = 1;
            label7.Text = "Practico 1, Gestion de proyectos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4893207;
            pictureBox1.Location = new Point(14, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnUsuario);
            panel2.Controls.Add(btnTarea);
            panel2.Controls.Add(btnProyectos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(833, 58);
            panel2.TabIndex = 17;
            // 
            // btnUsuario
            // 
            btnUsuario.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnUsuario.CheckedState.CustomBorderColor = Color.Red;
            btnUsuario.CustomBorderColor = Color.Navy;
            btnUsuario.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnUsuario.CustomizableEdges = customizableEdges2;
            btnUsuario.DisabledState.BorderColor = Color.DarkGray;
            btnUsuario.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUsuario.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUsuario.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUsuario.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnUsuario.Location = new Point(565, 7);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnUsuario.Size = new Size(265, 45);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuarios";
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnTarea
            // 
            btnTarea.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnTarea.CheckedState.CustomBorderColor = Color.Red;
            btnTarea.CustomBorderColor = Color.Navy;
            btnTarea.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnTarea.CustomizableEdges = customizableEdges4;
            btnTarea.DisabledState.BorderColor = Color.DarkGray;
            btnTarea.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTarea.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTarea.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTarea.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTarea.ForeColor = Color.White;
            btnTarea.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnTarea.Location = new Point(274, 7);
            btnTarea.Name = "btnTarea";
            btnTarea.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnTarea.Size = new Size(280, 45);
            btnTarea.TabIndex = 0;
            btnTarea.Text = "Tareas";
            btnTarea.Click += btnTarea_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnProyectos.Checked = true;
            btnProyectos.CheckedState.CustomBorderColor = Color.Red;
            btnProyectos.CustomBorderColor = Color.Navy;
            btnProyectos.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btnProyectos.CustomizableEdges = customizableEdges6;
            btnProyectos.DisabledState.BorderColor = Color.DarkGray;
            btnProyectos.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProyectos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProyectos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProyectos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProyectos.ForeColor = Color.White;
            btnProyectos.HoverState.CustomBorderColor = Color.FromArgb(192, 0, 0);
            btnProyectos.Location = new Point(3, 7);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnProyectos.Size = new Size(265, 45);
            btnProyectos.TabIndex = 0;
            btnProyectos.Text = "Proyectos";
            btnProyectos.Click += btnProyectos_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 121);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(833, 372);
            panelContainer.TabIndex = 18;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = Properties.Resources.logocftBChopped;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(766, 0);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(64, 63);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2CirclePictureBox1.TabIndex = 2;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 493);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
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
    }
}
