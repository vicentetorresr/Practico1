using Practico1.http;
using Practico1.modelos;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practico1.servicios
{
    public class TareaServicio : ConexionAApi
    {
        private readonly string groupKey = "/m3N4q5P6";

        // Método para obtener la lista de tareas
        public async Task<List<Tarea>> Index()
        {
            RespuestaListaDeTareas respuestaApi;
            try
            {
                string path = $"/tasks{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();

                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonRespuestaApi);

                if (respuestaApi == null || respuestaApi.Code != 200)
                {
                    MessageBox.Show("Error al obtener la lista de tareas: " + respuestaApi?.Message);
                    return new List<Tarea>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }


        // Método para obtener una tarea específica por ID (Read)
        public async Task<Tarea> Show(int tareaId)
        {
            Tarea tarea = null;
            string path = $"/tasks/{tareaId}{groupKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    RespuestaTarea respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(jsonRespuestaApi.Data.ToString());

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        tarea = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return tarea;
        }

        // metodo cargar tareas por proyecto
        public async Task<List<Tarea>> GetTareasPorProyecto(string proyectoIdStr)
        {
            var tareas = new List<Tarea>();
            string path = $"/tasks/{proyectoIdStr}{groupKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    var respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonRespuestaApi.Data.ToString());

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        tareas = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return tareas;
        }



        // Método para crear una nueva tarea (Create)
        public async Task<string> Create(Tarea nuevaTarea)
        {
            string respuestaApi = null;
            string path = $"/tasks{groupKey}";

            try
            {
                // Serializar el objeto actualizado a JSON
                string tareaJson = JsonSerializer.Serialize(nuevaTarea);

                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "POST");
                if (jsonRespuestaApi.Code == 201)
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    MessageBox.Show($"Error al crear la tarea: {jsonRespuestaApi.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}");
                throw; // Volver a lanzar la excepción para que el llamador pueda manejarla si es necesario
            }

            return respuestaApi;
        }



        // Método para actualizar una tarea existente (Update)
        public async Task<string> Update(int tareaId, object tareaActualizada)
        {
            string respuestaApi = null;
            string path = $"/tasks/{tareaId}{groupKey}";

            try
            {
                // Serializar el objeto actualizado a JSON
                string tareaJson = JsonSerializer.Serialize(tareaActualizada);
                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "PUT");

                // Verificar el código de respuesta para asegurar que la actualización fue exitosa
                if (jsonRespuestaApi.Code == 200) // código HTTP 200 significa que la actualización fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    // Manejo de error cuando el código de respuesta no es el esperado
                    MessageBox.Show("Error al actualizar la tarea: " + jsonRespuestaApi.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar una tarea existente (Delete)
        public async Task<string> Delete(int tareaId)
        {
            string respuestaApi = null;
            string path = $"/tasks/{tareaId}{groupKey}";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, "", "DELETE");

                // Verificar el código de respuesta para asegurar que la eliminación fue exitosa
                if (jsonRespuestaApi.Code == 200) // código HTTP 200 significa que la eliminación fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    // Manejo de error cuando el código de respuesta no es el esperado
                    MessageBox.Show("Error al eliminar la tarea: " + jsonRespuestaApi.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }
    }
}
