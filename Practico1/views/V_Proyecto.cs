using Practico1.modelos;
using Practico1.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1.views
{
    public partial class V_Proyecto : UserControl
    {

        private ProyectoServicio proyectoServicio;

        public V_Proyecto()
        {
            InitializeComponent();
            proyectoServicio = new ProyectoServicio();
            CargarProyectos();
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
