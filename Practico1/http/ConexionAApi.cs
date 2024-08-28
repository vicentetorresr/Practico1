using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Practico1.http
{
    public class ConexionAApi
    {
        private static readonly HttpClient httpClient = new HttpClient();
        readonly string baseurl = "https://www.tusitioexpress.cl/pa-infolutions/public/api";

        public async Task<RespuestaApi> SendTransaction(string pathInfo, string body, string method = "POST")
        {
            string url = baseurl + pathInfo;
            Clipboard.SetDataObject(body);
            Dictionary<string, string> headers = new()
            {
                // Aquí puedes añadir encabezados si es necesario, por ejemplo:
                // { "Authorization", "Bearer your_token_here" }
            };

            return await SendRequestAsync(url, body, method, headers);
        }

        public static async Task<RespuestaApi> SendRequestAsync(string url, string body, string method = "POST", Dictionary<string, string>? headers = null)
        {
            var response = new RespuestaApi();
            try
            {
                // Crear la solicitud HTTP
                HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(method), url);

                // Establecer el contenido si es un método POST o PUT
                if (method.Equals("POST", StringComparison.OrdinalIgnoreCase) ||
                    method.Equals("PUT", StringComparison.OrdinalIgnoreCase))
                {
                    request.Content = new StringContent(body, Encoding.UTF8, "application/json");
                }
                // No se establece contenido para DELETE
                else if (method.Equals("DELETE", StringComparison.OrdinalIgnoreCase))
                {
                    // DELETE no suele llevar un cuerpo
                    request.Content = null;
                }

                // Agregar headers a la solicitud
                if (headers != null && headers.Count > 0)
                {
                    foreach (var header in headers)
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }

                // Enviar la solicitud y obtener la respuesta
                HttpResponseMessage httpResponse = await httpClient.SendAsync(request);

                // Leer el contenido de la respuesta
                response.Code = (int)httpResponse.StatusCode;
                response.Message = httpResponse.ReasonPhrase;
                response.Data = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                response.Message = ex.Message;
                response.Code = 400; // Código de error genérico o personalizado
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Code = 400;
            }

            return response;
        }
    }
}
