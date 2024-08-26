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

        public Form1()
        {
            InitializeComponent();
            V_Proyecto v = new V_Proyecto();
            addUserView(v);
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
    }
}
