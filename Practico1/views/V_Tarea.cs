using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Practico1.modelos;
using Practico1.servicios;
using System.Windows.Forms;
using System.Text.Json; // Asegúrate de tener la referencia a System.Text.Json

namespace Practico1.views
{
    public partial class V_Tarea : UserControl
    {
        private TareaServicio tareaServicio; // Servicio para tareas
        private BindingList<Tarea> tareas; // Lista enlazada para tareas

        public V_Tarea()
        {
            init();
        }

        private void init()
        {
            InitializeComponent();
            tareaServicio = new TareaServicio();
            tareas = new BindingList<Tarea>();
            dgvTareas.DataSource = tareas;
            CargarTareas();
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
