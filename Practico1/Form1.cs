using Practico1.servicios;
using Practico1.modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class Form1 : Form
    {
        private ProyectoServicio proyectoServicio;

        public Form1()
        {
            InitializeComponent();
            proyectoServicio = new ProyectoServicio();
            CargarProyectos();  // Llamamos la funcion al cargar el formulario
        }

        private async void CargarProyectos()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Asignar la lista de proyectos como fuente de datos del DataGridView
                dgvProyecto.DataSource = listaDeProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
            }
        }
    }
}
