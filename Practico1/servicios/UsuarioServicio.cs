using Practico1.http;
using Practico1.modelos;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Practico1.servicios
{
    public class UsuarioServicio : ConexionAApi
    {
        private readonly string groupKey = "/m3N4q5P6";

        // Método para obtener la lista de usuarios (Index)
        public async Task<List<Usuario>> Index()
        {
            RespuestaListaDeUsuarios respuestaApi;
            try
            {
                string path = $"/users{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                string jsonRespuestaApi = response.Data.ToString();

                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeUsuarios>(jsonRespuestaApi);

                if (respuestaApi.Code != 200)
                {
                    // Manejo de error aquí
                    MessageBox.Show($"Error al obtener la lista de usuarios: {respuestaApi.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener un usuario específico por ID (Show)
        public async Task<Usuario> Show(int userId)
        {
            Usuario usuario = null;
            string path = $"/users/{userId}{groupKey}";
            string body = "";

            try
            {
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                if (jsonRespuestaApi != null && !string.IsNullOrEmpty(jsonRespuestaApi.Data.ToString()))
                {
                    RespuestaUsuario respuestaApi = JsonSerializer.Deserialize<RespuestaUsuario>(jsonRespuestaApi.Data.ToString());

                    if (respuestaApi != null && respuestaApi.Data != null)
                    {
                        usuario = respuestaApi.Data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return usuario;
        }
    }
}
