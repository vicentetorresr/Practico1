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
        public string Horas { get; set; } // Deserializa como string y se usa como Horas

        [JsonIgnore]
        public int HorasInt => int.TryParse(Horas, out int horas) ? horas : 0; // Propiedad que convierte Horas a int

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("project_id")]
        public string ProyectoId { get; set; } // Deserializa como string

        [JsonPropertyName("user_id")]
        public string EmpleadoAsignadoId { get; set; } // Deserializa como string

        // Constructor por defecto
        public Tarea() { }

        // Constructor para inicializar propiedades requeridas
        public Tarea(string descripcion, DateTime fechaInicio, string estado, string horas, string area, string proyectoId, string empleadoAsignadoId)
        {
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            FechaInicio = fechaInicio;
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Horas = horas ?? throw new ArgumentNullException(nameof(horas));
            Area = area ?? throw new ArgumentNullException(nameof(area));
            ProyectoId = proyectoId ?? throw new ArgumentNullException(nameof(proyectoId));
            EmpleadoAsignadoId = empleadoAsignadoId ?? throw new ArgumentNullException(nameof(empleadoAsignadoId));

            // Validación del estado permitido
            if (Estado != "pendiente" && Estado != "en progreso" && Estado != "finalizado")
            {
                throw new ArgumentException("Estado no válido. Valores aceptados: 'Pendiente', 'En progreso', 'Finalizado'.");
            }

            // Validación del área permitida
            if (Area != "hardware" && Area != "redes")
            {
                throw new ArgumentException("Área no válida. Valores aceptados: 'Hardware', 'Redes'.");
            }

            // Validación de horas mínimas
            if (int.TryParse(Horas, out int horasInt) && horasInt < 1)
            {
                throw new ArgumentException("Horas deben ser al menos 1.");
            }
        }
    }
}
