using Practico1.servicios;
using Practico1.modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico1.views;

namespace Practico1
{
    public partial class Form1 : Form
    {
        private bool isFullScreen = false;

        public Form1()
        {
            InitializeComponent();
            V_Proyecto v = new V_Proyecto();
            addUserView(v);
            panelContainer.BackColor = Color.Beige;
        }

        private void addUserView(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnProyectos_Click(object sender, EventArgs e)
        {
            V_Proyecto v = new V_Proyecto();
            addUserView(v);
        }

        private void btnTarea_Click(object sender, EventArgs e)
        {
            V_Tarea v = new V_Tarea();
            addUserView(v);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            V_Usuario v = new V_Usuario();
            addUserView(v);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPantallaCompleta_Click(object sender, EventArgs e)
        {

            if (!isFullScreen)
            {
                // Cambiar a pantalla completa
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                isFullScreen = true;
            }
            else
            {
                // Salir de pantalla completa
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                isFullScreen = false;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExpadir_Click(object sender, EventArgs e)
        {
            if (!isFullScreen)
            {
                // Cambiar a pantalla completa
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                isFullScreen = true;
            }
            else
            {
                // Salir de pantalla completa
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                isFullScreen = false;
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsalir_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
