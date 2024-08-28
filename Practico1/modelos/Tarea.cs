using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Practico1.modelos
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("start_date")]
        public string Start_date { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("hours")]
        public string Hours { get; set; } 

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("project_id")]
        public string Project_id { get; set; }

        [JsonPropertyName("user_id")]
        public string User_id { get; set; }

        // Constructor por defecto
        public Tarea() { }

        // Constructor para inicializar propiedades requeridas
        public Tarea(string descripcion, string fechaInicio, string estado, string horas, string area, string proyectoId, string empleadoAsignadoId)
        {
            Description = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
            Start_date = fechaInicio;
            Status = estado ?? throw new ArgumentNullException(nameof(estado));
            Hours = horas ?? throw new ArgumentNullException(nameof(horas));
            Area = area ?? throw new ArgumentNullException(nameof(area));
            Project_id = proyectoId ?? throw new ArgumentNullException(nameof(proyectoId));
            User_id = empleadoAsignadoId ?? throw new ArgumentNullException(nameof(empleadoAsignadoId));

            MessageBox.Show(descripcion,fechaInicio);

            // Validación del estado permitido
            if (Status != "pendiente" && Status != "en progreso" && Status != "finalizado")
            {
                throw new ArgumentException("Estado no válido. Valores aceptados: 'Pendiente', 'En progreso', 'Finalizado'.");
            }

            // Validación del área permitida
            if (Area != "hardware" && Area != "redes")
            {
                throw new ArgumentException("Área no válida. Valores aceptados: 'Hardware', 'Redes'.");
            }

            // Validación de horas mínimas
            if (int.TryParse(Hours, out int horasInt) && horasInt < 1)
            {
                throw new ArgumentException("Horas deben ser al menos 1.");
            }
        }
    }
}
