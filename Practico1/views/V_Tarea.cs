using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Practico1.modelos;
using Practico1.servicios;
using System.Windows.Forms;

namespace Practico1.views
{
    public partial class V_Tarea : UserControl
    {
        private TareaServicio tareaServicio; // Servicio para tareas
        private ProyectoServicio proyectoServicio; // Servicio para proyectos (suponiendo que tienes uno)
        private BindingList<Tarea> tareas; // Lista enlazada para tareas

        public V_Tarea()
        {
            InitializeComponent();
            tareaServicio = new TareaServicio();
            proyectoServicio = new ProyectoServicio(); // Suponiendo que tienes un servicio para proyectos
            tareas = new BindingList<Tarea>();
            dgvTareas.DataSource = tareas;

            // Configurar el ComboBox
            cbProyectos.SelectedIndexChanged += CbProyectos_SelectedIndexChanged;

            // Cargar proyectos en el ComboBox
            CargarProyectos();
        }

        private async void CargarProyectos()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Configurar el ComboBox
                cbProyectos.DisplayMember = "Nombre"; // Asume que el modelo de Proyecto tiene una propiedad "Nombre"
                cbProyectos.ValueMember = "Id"; // Asume que el modelo de Proyecto tiene una propiedad "Id"
                cbProyectos.DataSource = listaDeProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
            }
        }

        private async void CbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbProyectos.SelectedValue != null)
                {
                    // Obtener el ID del proyecto seleccionado
                    string proyectoIdStr = cbProyectos.SelectedValue.ToString();

                    // Llamar al nuevo método para obtener la lista de tareas filtradas por el proyecto seleccionado
                    List<Tarea> listaDeTareas = await tareaServicio.GetTareasPorProyecto(proyectoIdStr);

                    // Asignar la lista de tareas al BindingList
                    tareas.Clear();
                    foreach (var tarea in listaDeTareas)
                    {
                        tareas.Add(tarea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}");
            }
        }


        private async void CargarTareas()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de tareas
                List<Tarea> listaDeTareas = await tareaServicio.Index();

                // Asignar la lista de tareas al BindingList
                tareas.Clear();
                foreach (var tarea in listaDeTareas)
                {
                    tareas.Add(tarea);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}");
            }
        }
    }
}
