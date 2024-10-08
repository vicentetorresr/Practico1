﻿using Practico1.modelos;
using Practico1.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1.views
{
    public partial class V_Proyecto : UserControl
    {

        private ProyectoServicio proyectoServicio;
        private BindingList<Proyecto> proyectos;

        private TareaServicio tareaServicio;
        private BindingList<Tarea> tareas;


        public V_Proyecto()
        {
            init();
        }
        private void init()
        {
            InitializeComponent();

            // Instancia de lista de proyectos
            proyectoServicio = new ProyectoServicio();
            proyectos = new BindingList<Proyecto>();
            dgvProyecto.DataSource = proyectos;
            CargarProyectos();

            // instancia de lista de Task (programando en ingles)
            tareaServicio = new TareaServicio();
            tareas = new BindingList<Tarea>();
            dgvLoadTareas.DataSource = tareas;

        }
        private async void CargarProyectos()
        {
            try
            {
                // Llamar al método Index del servicio para obtener la lista de proyectos
                List<Proyecto> listaDeProyectos = await proyectoServicio.Index();

                // Asignar la lista de proyectos al BindingList
                proyectos.Clear();
                foreach (var proyecto in listaDeProyectos)
                {
                    proyectos.Add(proyecto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtWorkHours.Enabled = false;
            unShow();
            txtId.ResetText();
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            txtWorkHours.ResetText();
            txtTotalHour.ResetText();
            tareas.Clear();
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



        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si el campo ID no está vacío y es un número válido
                if (int.TryParse(txtId.Text, out int projectId))
                {
                    // Verificar si los campos de horas son números válidos
                    bool isTotalHoursValid = int.TryParse(txtTotalHour.Text, out int totalHours);
                    bool isWorkHoursValid = int.TryParse(txtWorkHours.Text, out int workHours);

                    if (isTotalHoursValid && isWorkHoursValid)
                    {
                        // Crear un objeto con los datos actualizados del proyecto
                        var proyectoActualizado = new
                        {
                            id = projectId,
                            name = txtNombre.Text,
                            description = txtDescripcion.Text,
                            workerHours = workHours,
                            totalHours = totalHours
                        };

                        // Confirmar la actualización con el usuario
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea actualizar este proyecto?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                // Llamar a la API para actualizar el proyecto
                                ProyectoServicio proyectoServicio = new ProyectoServicio();
                                string resultado = await proyectoServicio.Update(projectId, proyectoActualizado);

                                // Verificar si la actualización fue exitosa
                                if (!string.IsNullOrEmpty(resultado))
                                {
                                    MessageBox.Show("Proyecto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarProyectos();
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Error al actualizar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Manejar cualquier excepción que ocurra durante la llamada a la API
                                MessageBox.Show($"Se produjo un error al actualizar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // Mostrar mensaje de error si las horas no son válidas
                        MessageBox.Show("Por favor, ingrese valores válidos para las horas de trabajo y horas totales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de proyecto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales no anticipados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvProyecto.CurrentRow != null && dgvProyecto.CurrentRow.Index >= 0)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = dgvProyecto.CurrentRow.Index;

                    // Obtener el ID del proyecto de la fila seleccionada
                    if (int.TryParse(dgvProyecto.Rows[rowIndex].Cells["id"].Value.ToString(), out int projectId))
                    {
                        // Confirmar la eliminación con el usuario
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este proyecto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                // Llamar a la API para eliminar el proyecto
                                string resultado = await proyectoServicio.Delete(projectId);

                                // Verificar si la eliminación fue exitosa
                                if (!string.IsNullOrEmpty(resultado))
                                {
                                    // Eliminar el proyecto de la lista
                                    var proyectoEliminar = proyectos.FirstOrDefault(p => p.Id == projectId);
                                    if (proyectoEliminar != null)
                                    {
                                        proyectos.Remove(proyectoEliminar);
                                    }

                                    MessageBox.Show("Proyecto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Error al eliminar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Manejar cualquier excepción que ocurra durante la llamada a la API
                                MessageBox.Show($"Se produjo un error al eliminar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID del proyecto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un proyecto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales no anticipados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar si el campo de horas totales es un número válido
                bool isTotalHoursValid = int.TryParse(txtTotalHour.Text, out int totalHours);

                if (!isTotalHoursValid)
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para las horas totales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto del nuevo proyecto con los valores de los campos de texto
                var nuevoProyecto = new
                {
                    name = txtNombre.Text.Trim(),
                    description = txtDescripcion.Text.Trim(),
                    status = "Pendiente", // Estado inicial del proyecto
                    totalHours = totalHours,
                    created_at = DateTime.Now.ToString("yyyy-MM-dd")
                };

                try
                {
                    // Llamar a la API para crear el nuevo proyecto
                    ProyectoServicio proyectoServicio = new ProyectoServicio();
                    string resultado = await proyectoServicio.Create(nuevoProyecto);

                    // Verificar si la creación fue exitosa
                    if (!string.IsNullOrEmpty(resultado))
                    {
                        MessageBox.Show("Proyecto creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProyectos();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra durante la llamada a la API
                    MessageBox.Show($"Se produjo un error al crear el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales no anticipados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // METODO CLICK AL DATAGRIDVIEW
        private void dgvProyecto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada no sea la fila del encabezado (índice de fila -1)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvProyecto.Rows[e.RowIndex];

                // Establecer los valores de las celdas en los campos de texto correspondientes
                txtId.Text = selectedRow.Cells["id"].Value.ToString();
                txtNombre.Text = selectedRow.Cells["name"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["description"].Value.ToString();
                txtWorkHours.Text = selectedRow.Cells["workerhours"].Value.ToString();
                txtTotalHour.Text = selectedRow.Cells["totalhours"].Value.ToString();

                // Verifica que los datos de la celda no sean nulos antes de convertirlos a cadena.
                txtId.Text = selectedRow.Cells["id"].Value?.ToString() ?? string.Empty;
                txtNombre.Text = selectedRow.Cells["name"].Value?.ToString() ?? string.Empty;
                txtDescripcion.Text = selectedRow.Cells["description"].Value?.ToString() ?? string.Empty;
                txtWorkHours.Text = selectedRow.Cells["workerhours"].Value?.ToString() ?? string.Empty;
                txtTotalHour.Text = selectedRow.Cells["totalhours"].Value?.ToString() ?? string.Empty;
                showBtn();
                try
                {
                    CargarTareas(int.Parse(txtId.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar las tareas por proyecto: '" + ex + "'");
                }
            }
        }




        // Cargar tareas xp royecto:
        private async void CargarTareas(int idProyecto)
        {
            try
            {
                // Llamar al método GetTareasPorProyecto del servicio para obtener la lista de tareas filtradas
                List<Tarea> listaDeTareas = await tareaServicio.GetTareasPorProyecto(idProyecto);

                // Verificar si la lista de tareas es nula
                if (listaDeTareas == null || !listaDeTareas.Any())
                {
                    MessageBox.Show("No se obtuvieron tareas del servicio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asegurarse de que la lista de tareas esté inicializada
                if (tareas == null)
                {
                    tareas = new BindingList<Tarea>();
                }

                // Limpiar la lista y agregar las tareas obtenidas
                tareas.Clear();
                foreach (var tarea in listaDeTareas)
                {
                    tareas.Add(tarea);
                }
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"Error en el procesamiento de datos JSON al cargar las tareas: {jsonEx.Message}", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las tareas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FinalizarProyectotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (dgvProyecto.CurrentRow != null && dgvProyecto.CurrentRow.Index >= 0)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = dgvProyecto.CurrentRow.Index;

                    // Obtener el ID del proyecto de la fila seleccionada
                    if (int.TryParse(dgvProyecto.Rows[rowIndex].Cells["id"].Value.ToString(), out int projectId))
                    {
                        // Confirmar la finalización con el usuario
                        DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea finalizar este proyecto?", "Confirmar Finalización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            try
                            {
                                // Crear un objeto con el estado actualizado del proyecto
                                var proyectoFinalizado = new
                                {
                                    id = projectId,
                                    status = "Finalizado" // Estado actualizado del proyecto
                                };

                                // Llamar a la API para actualizar el estado del proyecto
                                ProyectoServicio proyectoServicio = new ProyectoServicio();
                                string resultado = await proyectoServicio.Update(projectId, proyectoFinalizado);

                                // Verificar si la actualización fue exitosa
                                if (!string.IsNullOrEmpty(resultado))
                                {
                                    MessageBox.Show("Proyecto finalizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarProyectos();
                                    limpiar();
                                }
                                else
                                {
                                    MessageBox.Show("Error al finalizar el proyecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Manejar cualquier excepción que ocurra durante la llamada a la API
                                MessageBox.Show($"Se produjo un error al finalizar el proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID del proyecto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un proyecto para finalizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores generales no anticipados
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEliminar_menustrip_Opening(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Por favor, seleccione una opcion.");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text.ToLower().Trim();
            if (!string.IsNullOrEmpty(filtro))
            {
                // Filtrar los datos
                var proyectosFiltrados = proyectos
                    .Where(p =>
                        (p.Name != null && p.Name.ToLower().Contains(filtro)) ||
                        (p.Description != null && p.Description.ToLower().Contains(filtro)) ||
                        (p.Status != null && p.Status.ToLower().Contains(filtro))
                    )
                    .ToList();

                dgvProyecto.DataSource = new BindingList<Proyecto>(proyectosFiltrados);
            }
            else
            {
                // Si el filtro está vacío, muestra todos los datos
                dgvProyecto.DataSource = proyectos;
            }
        }


        // fin del codigo
    }
}
