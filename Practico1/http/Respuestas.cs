using Practico1.modelos;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Practico1.http
{
    public class RespuestaBase<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }

    public class RespuestaApi : RespuestaBase<object>
    {
    }

    public class RespuestaListaDeProyectos : RespuestaBase<List<Proyecto>>
    {
    }

    public class RespuestaProyecto : RespuestaBase<Proyecto>
    {
    }

    public class RespuestaCreacionProyecto : RespuestaBase<Proyecto>
    {
    }

    // Nueva clase para respuesta de lista de tareas
    public class RespuestaListaDeTareas : RespuestaBase<List<Tarea>>
    {
    }

    // Nueva clase para respuesta de una tarea
    public class RespuestaTarea : RespuestaBase<Tarea>
    {
    }

    // Nueva clase para respuesta de creación de tarea
    public class RespuestaCreacionTarea : RespuestaBase<Tarea>
    {
    }

    // Nueva clase para respuesta de lista de usuarios
    public class RespuestaListaDeUsuarios : RespuestaBase<List<Usuario>>
    {
    }

    // Nueva clase para respuesta de un usuario
    public class RespuestaUsuario : RespuestaBase<Usuario>
    {
    }
}
