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
        private TareaServicio tareaServicio;
        private ProyectoServicio proyectoServicio;
        private UsuarioServicio usuarioServicio;

        private BindingList<Tarea> tareas;
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
            try
            {
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

        private void cbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (int)cbProyectos.SelectedValue;
            idProyec = selectedValue;
        }

        private void cbUsuarioAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = (int)cbUsuarioAsignado.SelectedValue;
            idUsu = selectedValue;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
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

                    // Obtener el proyecto para verificar el total de horas
                    var proyecto = await proyectoServicio.Show(idProyec);

                    if (proyecto == null)
                    {
                        MessageBox.Show("No se encontró el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Convertir TotalHours y WorkerHours a enteros
                    if (!int.TryParse(proyecto.TotalHours, out int totalHorasProyecto) ||
                        !int.TryParse(proyecto.WorkerHours, out int workerHorasProyecto))
                    {
                        MessageBox.Show("Error al convertir las horas del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verificar si las horas ingresadas no exceden el total de horas del proyecto
                    if (workerHorasProyecto + horas > totalHorasProyecto)
                    {
                        MessageBox.Show("Las horas ingresadas exceden el total de horas del proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Determinar el estado de la tarea
                    string estadoTarea;
                    if (workerHorasProyecto + horas == totalHorasProyecto)
                    {
                        estadoTarea = "finalizado";
                    }
                    else if (workerHorasProyecto + horas > 0)
                    {
                        estadoTarea = "en progreso";
                    }
                    else
                    {
                        estadoTarea = "pendiente";
                    }

                    // Crear una instancia de Tarea
                    var nuevaTarea = new Tarea
                    {
                        Description = txtDescripcion.Text.Trim(),
                        Start_date = fech,
                        Status = estadoTarea,
                        Hours = horas,
                        Area = area,
                        Project_id = idProyec,
                        User_id = idUsu
                    };

                    // Crear la tarea en el servicio
                    string resultado = await tareaServicio.Create(nuevaTarea);

                    if (!string.IsNullOrEmpty(resultado))
                    {
                        // Actualizar el proyecto con las nuevas horas trabajadas
                        proyecto.WorkerHours = (workerHorasProyecto + horas).ToString();
                        if (workerHorasProyecto + horas == totalHorasProyecto)
                        {
                            proyecto.Status = "finalizado";
                        }
                        else if (workerHorasProyecto + horas > 0)
                        {
                            proyecto.Status = "en progreso";
                        }

                        // Actualizar el proyecto en el servicio
                        await proyectoServicio.Update(idProyec, proyecto);

                        CargarTareas();
                        MessageBox.Show("Tarea guardada exitosamente.");
                        limpiar();
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





















        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el campo ID no está vacío y es un número válido
                if (int.TryParse(txtId.Text, out int tareaId))
                {
                    // Verificar si los campos de horas son números válidos
                    bool isHoursValid = int.TryParse(txtHoras.Text, out int horas);
                    var fech = DateTime.Now.ToString("yyyy-MM-dd");
                    if (isHoursValid)
                    {
                        // Crear un objeto con los datos actualizados de la tarea
                        var tareaActualizada = new Tarea
                        {
                            Id = tareaId,
                            Description = txtDescripcion.Text.Trim(),
                            Start_date = fech,
                            Status = "pendiente",
                            Hours = horas,
                            Area = (string)cbArea.SelectedItem,
                            Project_id = idProyec,
                            User_id = idUsu
                        };

                        // Confirmar la actualización con el usuario
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea actualizar esta tarea?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                // Llamar a la API para actualizar la tarea
                                string resultado = await tareaServicio.Update(tareaId, tareaActualizada);

                                // Verificar si la actualización fue exitosa
                                if (!string.IsNullOrEmpty(resultado))
                                {
                                    MessageBox.Show("Tarea actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarTareas();
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Manejar cualquier excepción que ocurra durante la llamada a la API
                                MessageBox.Show($"Se produjo un error al actualizar la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // Mostrar mensaje de error si las horas no son válidas
                        MessageBox.Show("Por favor, ingrese valores válidos para las horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de tarea válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales no anticipados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_menustrip_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int tareaId))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta tarea?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string resultado = await tareaServicio.Delete(tareaId);

                        if (!string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("Tarea eliminada exitosamente.");
                            CargarTareas();
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la tarea.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
            }
        }

        private void limpiar()
        {
            try
            {
                // Verificar que cada control no sea null antes de acceder a sus propiedades
                if (txtDescripcion != null)
                {
                    txtDescripcion.Text = string.Empty;
                }

                if (txtHoras != null)
                {
                    txtHoras.Text = "0";
                }

                // Verificar si el ComboBox 'cbArea' no es null y tiene elementos antes de intentar cambiar el índice seleccionado
                if (cbArea != null && cbArea.Items.Count > 0)
                {
                    cbArea.SelectedIndex = -1;
                }

                // Verificar si el ComboBox 'cbProyectos' no es null y tiene elementos antes de intentar cambiar el índice seleccionado
                if (cbProyectos != null)
                {
                    try
                    {
                        // Intentar acceder a los elementos del ComboBox
                        if (cbProyectos.Items.Count > 0)
                        {
                            cbProyectos.SelectedIndex = -1;
                        }
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        // Manejar error de índice fuera de rango para 'cbProyectos'
                        //MessageBox.Show($"Error al restablecer la selección de 'cbProyectos': {ex.Message}", "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier otro error inesperado con 'cbProyectos'
                        //MessageBox.Show($"Ocurrió un error inesperado con 'cbProyectos': {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Verificar si el ComboBox 'cbUsuarioAsignado' no es null y tiene elementos antes de intentar cambiar el índice seleccionado
                if (cbUsuarioAsignado != null)
                {
                    try
                    {
                        // Intentar acceder a los elementos del ComboBox
                        if (cbUsuarioAsignado.Items.Count > 0)
                        {
                            cbUsuarioAsignado.SelectedIndex = -1;
                        }
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        // Manejar error de índice fuera de rango para 'cbUsuarioAsignado'
                        //MessageBox.Show($"Error al restablecer la selección de 'cbUsuarioAsignado': {ex.Message}", "Error de Índice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier otro error inesperado con 'cbUsuarioAsignado'
                        //MessageBox.Show($"Ocurrió un error inesperado con 'cbUsuarioAsignado': {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (txtId != null)
                {
                    txtId.Text = string.Empty;
                }

                // Verificar que el método unShow() existe antes de llamarlo
                unShow();
            }
            catch (NullReferenceException ex)
            {
                // Manejar el caso cuando algún control es nulo
                MessageBox.Show($"Error al acceder a un control de la interfaz: {ex.Message}", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo general de errores para cualquier otra excepción
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void showBtn()
        {
            btnIngresar.Enabled = false;
            btnIngresar.Visible = false;

            btnCancelar.Enabled = true;
            btnCancelar.Visible = true;

            btnActualizar.Enabled = true;
            btnActualizar.Visible = true;
        }

        private void unShow()
        {
            btnCancelar.Enabled = false;
            btnCancelar.Visible = false;
            btnActualizar.Enabled = false;
            btnActualizar.Visible = false;

            btnIngresar.Enabled = true;
            btnIngresar.Visible = true;
        }

        private void dgvTareas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTareas.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "pendiente")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Red;
                }
                else if (status == "en progreso")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Yellow;
                }
                else if (status == "finalizado")
                {
                    e.CellStyle.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvTareas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que la fila seleccionada no sea la fila del encabezado (índice de fila -1)
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dgvTareas.Rows[e.RowIndex];

                    // Establecer los valores de las celdas en los campos de texto correspondientes
                    txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty;
                    txtHoras.Text = selectedRow.Cells["Hours"].Value?.ToString() ?? "0"; // Asignar valor de horas

                    // Verificar que las celdas de ComboBox no sean nulas antes de asignar valores
                    var areaValue = selectedRow.Cells["Area"].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(areaValue) && cbArea.Items.Contains(areaValue))
                    {
                        cbArea.SelectedItem = areaValue;
                    }
                    else
                    {
                        cbArea.SelectedIndex = -1; // Si el valor no está en la lista, deselecciona
                    }

                    var proyectoIdValue = selectedRow.Cells["Project_id"].Value;
                    if (proyectoIdValue != null)
                    {
                        cbProyectos.SelectedValue = proyectoIdValue;
                    }
                    else
                    {
                        cbProyectos.SelectedIndex = -1;
                    }

                    var usuarioIdValue = selectedRow.Cells["User_id"].Value;
                    if (usuarioIdValue != null)
                    {
                        cbUsuarioAsignado.SelectedValue = usuarioIdValue;
                    }
                    else
                    {
                        cbUsuarioAsignado.SelectedIndex = -1;
                    }

                    showBtn();
                }
            }
            catch
            {
            }
        }


        private async void btnFinalizar_menustrip_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Por favor, seleccione una opcion.");
        }

        private async void eliminaarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int tareaId))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta tarea?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string resultado = await tareaServicio.Delete(tareaId);

                        if (!string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("Tarea eliminada exitosamente.");
                            CargarTareas();
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la tarea.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
            }
        }

        private async void FinalizartoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int tareaId))
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea finalizar esta tarea?", "Confirmar Finalización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        var tarea = await tareaServicio.Show(tareaId); // Obtener la tarea por ID
                        if (tarea != null)
                        {
                            // Actualizar el estado de la tarea a "finalizado"
                            tarea.Status = "finalizado";

                            // Llamar al servicio para actualizar la tarea
                            string resultado = await tareaServicio.Update(tareaId, tarea);

                            if (!string.IsNullOrEmpty(resultado))
                            {
                                MessageBox.Show("Tarea finalizada exitosamente.");
                                CargarTareas(); // Recargar la lista de tareas
                                limpiar(); // Limpiar los campos
                            }
                            else
                            {
                                MessageBox.Show("Error al finalizar la tarea.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tarea no encontrada.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una opcion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

    }
    

}
