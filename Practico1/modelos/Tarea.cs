using System;
using System.Text.Json.Serialization;

namespace Practico1.modelos
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Descripcion { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime FechaInicio { get; set; }

        [JsonPropertyName("status")]
        public string Estado { get; set; }

        [JsonPropertyName("hours")]
        public int Horas { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("project_id")]
        public int ProyectoId { get; set; } // Clave foránea para Proyecto

        [JsonPropertyName("user_id")]
        public int EmpleadoAsignadoId { get; set; } // Clave foránea para Usuarios

        // Constructor por defecto
        public Tarea() { }

        // Constructor para inicializar propiedades requeridas
        public Tarea(string descripcion, DateTime fechaInicio, string estado, int horas, string area, int proyectoId, int empleadoAsignadoId)
        {
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            FechaInicio = fechaInicio;
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Horas = horas;
            Area = area ?? throw new ArgumentNullException(nameof(area));
            ProyectoId = proyectoId;
            EmpleadoAsignadoId = empleadoAsignadoId;

            // Validación del estado permitido
            if (Estado != "Pendiente" && Estado != "En progreso" && Estado != "Finalizado")
            {
                throw new ArgumentException("Estado no válido. Valores aceptados: 'Pendiente', 'En progreso', 'Finalizado'.");
            }

            // Validación del área permitida
            if (Area != "Hardware" && Area != "Redes")
            {
                throw new ArgumentException("Área no válida. Valores aceptados: 'Hardware', 'Redes'.");
            }

            // Validación de horas mínimas
            if (Horas < 1)
            {
                throw new ArgumentException("Horas deben ser al menos 1.");
            }
        }
    }
}
