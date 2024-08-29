using Practico1.servicios;
using Practico1.modelos;
using System;
using System.Drawing;
using System.Windows.Forms;
using Practico1.views;

namespace Practico1
{
    public partial class Form1 : Form
    {
        private bool isFullScreen = false;
        private bool isDragging = false;
        private Point lastCursor;
        private Point formOffset;

        public Form1()
        {
            InitializeComponent();
            V_Proyecto v = new V_Proyecto();
            addUserView(v);
            panelContainer.BackColor = Color.Beige;

            // Configura eventos para el panel
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
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
                this.FormBorderStyle = FormBorderStyle.Sizable; // Cambiar a Sizable
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                isFullScreen = false;
            }
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
                this.FormBorderStyle = FormBorderStyle.Sizable; // Cambiar a Sizable
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;
                isFullScreen = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = e.Location;
                formOffset = new Point(this.Left - MousePosition.X, panelContainer.Top - MousePosition.Y);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = new Point(MousePosition.X + formOffset.X, MousePosition.Y + formOffset.Y);
                this.Location = newLocation;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
