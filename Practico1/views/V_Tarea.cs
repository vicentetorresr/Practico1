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
        private ProyectoServicio proyectoServicio; // Servicio para proyectos
        private UsuarioServicio usuarioServicio; // Servicio para usuarios

        private BindingList<Tarea> tareas; // Lista enlazada para tareas
        private BindingList<Usuario> usuario;

        int idProyec;
        int idUsu;

        public V_Tarea()
        {
            InitializeComponent();
            tareaServicio = new TareaServicio();
            proyectoServicio = new ProyectoServicio(); // Inicializar el servicio de proyectos
            usuarioServicio = new UsuarioServicio();   // Inicializar el servicio de usuarios

            tareas = new BindingList<Tarea>();
            dgvTareas.DataSource = tareas;

            // Cargar datos en los ComboBoxes
            CargarTareas();
            CargarProyectos();
            CargarUsuarios(); // Asegúrate de llamar a CargarUsuarios
        }

        private async void CargarProyectos()
        {
            try
            {
                cbProyectos.Items.Insert(0, "Todos");

                // Llamar al método Index del servicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Configurar el ComboBox
                cbProyectos.DisplayMember = "Name";
                cbProyectos.ValueMember = "Id";
                cbProyectos.DataSource = listaDeProyectos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
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

        private async void CargarUsuarios()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de usuarios
                List<Usuario> listaDeUsuarios = await usuarioServicio.Index();

                // Configurar el ComboBox
                cbUsuarioAsignado.DisplayMember = "Nombre";
                cbUsuarioAsignado.ValueMember = "Id";
                cbUsuarioAsignado.DataSource = listaDeUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        private void dgvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // aqui debe cargar la tarea de la tabla a los inputs
        }

        private void cbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Almacenamos la variable que este en el combobox
            idProyec = (int)cbProyectos.SelectedValue;
        }

        private void cbUsuarioAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsu = (int)cbUsuarioAsignado.SelectedValue;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {


        }
    }
}