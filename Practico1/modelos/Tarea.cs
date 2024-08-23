using System;
using System.Text.Json.Serialization;

namespace Practico1.modelos
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("fechaInicio")]
        public DateTime FechaInicio { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }

        [JsonPropertyName("horas")]
        public int Horas { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("proyectoId")]
        public int ProyectoId { get; set; } // Clave foránea para Proyecto

        [JsonPropertyName("empleadoAsignadoId")]
        public int EmpleadoAsignadoId { get; set; } // Clave foránea para Usuarios

        // Constructor para inicializar propiedades requeridas
        public Tarea(DateTime fechaInicio, string estado, int horas, string area, int proyectoId, int empleadoAsignadoId)
        {
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
