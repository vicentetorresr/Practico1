using Practico1.http;
using Practico1.modelos;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Practico1.servicios
{
    public class ProyectoServicio : ConexionAApi
    {
        private readonly string groupKey = "/m3N4q5P6";

        // Método para obtener la lista de proyectos 
        public async Task<List<Proyecto>> Index()
        {
            RespuestaListaDeProyectos respuestaApi;
            try
            {
                string path = $"/projects{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();

                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

                if (respuestaApi.Code != 200)
                {
                    // Manejo de error aquí
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un proyecto específico por ID (Read)
        public async Task<Proyecto> Show(int projectId)
        {
            Proyecto proyecto = null;
            string path = $"/projects/{projectId}{groupKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    RespuestaProyecto respuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(jsonRespuestaApi.Data.ToString());

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        proyecto = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return proyecto;
        }

        // Método para crear un nuevo proyecto (Create)
        public async Task<String> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects{groupKey}";

            try
            {
                // Serializar el objeto anónimo a JSON, ya que la api debe recibir ese formato, no un obj de .net
                string proyectoJson = JsonSerializer.Serialize(nuevoProyecto);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "POST");

                if (jsonRespuestaApi.Code == 201) //codigo http quiere decir que se creó el proyecto
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }

        // Método para actualizar un proyecto existente (Update)
        public async Task<string> Update(int projectId, object proyectoActualizado)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{groupKey}";

            try
            {
                // Serializar el objeto actualizado a JSON
                string proyectoJson = JsonSerializer.Serialize(proyectoActualizado);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "PUT");

                // Verificar el código de respuesta para asegurar que la actualización fue exitosa
                if (jsonRespuestaApi.Code == 200) // código HTTP 200 significa que la actualización fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    // Manejo del error cuando el código de respuesta no es el esperado
                    MessageBox.Show("Error al actualizar el proyecto: " + jsonRespuestaApi.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar un proyecto existente (Delete)
        public async Task<string> Delete(int projectId)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}{groupKey}";

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
                    // Manejo del error cuando el código de respuesta no es el esperado
                    MessageBox.Show("Error al eliminar el proyecto: " + jsonRespuestaApi.Message);
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
