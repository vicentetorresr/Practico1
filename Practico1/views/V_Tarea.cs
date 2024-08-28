using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Practico1.modelos;
using Practico1.servicios;
using System.Windows.Forms;
using System.Text.Json;

namespace Practico1.views
{
    public partial class V_Tarea : UserControl
    {
        private const string Format = "yyyy-MM-dd";
        private TareaServicio tareaServicio; // Servicio para tareas
        private ProyectoServicio proyectoServicio; // Servicio para proyectos
        private UsuarioServicio usuarioServicio; // Servicio para usuarios

        private BindingList<Tarea> tareas; // Lista enlazada para tareas
        private BindingList<Usuario> usuarios;

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

            idProyec = 1;
            idUsu = 1;

            // Cargar datos en los ComboBoxes
            CargarTareas();
            CargarProyectos();
            CargarUsuarios();
        }

        private async void CargarProyectos()
        {
            try { 

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

                // Verificar si la lista de tareas es nula
                if (listaDeTareas == null)
                {
                    MessageBox.Show("No se obtuvieron tareas del servicio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asegurarse de que la lista de tareas esté inicializada
                if (tareas == null)
                {
                    tareas = new BindingList<Tarea>();
                }

                // Asignar la lista de tareas al BindingList
                tareas.Clear();
                foreach (var tarea in listaDeTareas)
                {
                    tareas.Add(tarea);
                }
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"Error en el procesamiento de datos JSON al cargar tareas: {jsonEx.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Asegurarse de que se seleccionó una fila válida
            /*
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvTareas.Rows[e.RowIndex];
                txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value?.ToString() ?? string.Empty;
                txtHoras.Text = selectedRow.Cells["Horas"].Value?.ToString() ?? "0"; // Asignar valor de horas
                cbArea.SelectedItem = selectedRow.Cells["Area"].Value?.ToString() ?? string.Empty;
                cbProyectos.SelectedValue = selectedRow.Cells["ProyectoId"].Value?.ToString() ?? string.Empty;
                cbUsuarioAsignado.SelectedValue = selectedRow.Cells["EmpleadoAsignadoId"].Value?.ToString() ?? string.Empty;
            }
            */
        }

        private void cbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (int) cbProyectos.SelectedValue;
            idProyec = selectedValue;
        }

        private void cbUsuarioAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (int)cbUsuarioAsignado.SelectedValue ;
            idUsu = selectedValue;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string horasText = txtHoras.Text;
                var fech = DateTime.Now.ToString("yyyy-MM-dd");

                if (int.TryParse(horasText, out int horas) && horas >= 0)
                {
                    string area = (string)cbArea.SelectedItem;

                    // Verificar si idProyec e idUsu son mayores o iguales a 0
                    if (string.IsNullOrEmpty(area) || idProyec < 0 || idUsu < 0)
                    {
                        MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Crear una instancia de Tarea
                    var nuevaTarea = new Tarea
                    {
                        Description = txtDescripcion.Text.Trim(),
                        Start_date = fech,
                        Status = "pendiente",
                        Hours = horas,
                        Area = area,
                        Project_id = idProyec,
                        User_id = idUsu
                    };

                    TareaServicio tareaServicio = new TareaServicio();
                    string resultado = await tareaServicio.Create(nuevaTarea);

                    if (!string.IsNullOrEmpty(resultado))
                    {
                        CargarTareas();
                        MessageBox.Show("Tarea guardada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar la tarea.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para las horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



















    }
}
