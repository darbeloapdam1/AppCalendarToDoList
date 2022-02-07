using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCalendarToDoList.Model
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100), NotNull]
        public string titulo { get; set; }
        [MaxLength(1000), NotNull]
        public string objetivos { get; set; }
        [NotNull]
        public DateTime fechaInicio { get; set; }
        [NotNull]
        public DateTime fechaFinal { get; set; }
        public int prioridad { get; set; }
        public bool completado { get; set; }
        [NotNull]
        public int color { get; set; }

        public Tarea() { }
        public Tarea(string titulo, string objetivos, DateTime fechaInicio, DateTime fechaFinal, 
            int prioridad, bool compleatdo, int color)
        {
            this.titulo = titulo;
            this.objetivos = objetivos;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.prioridad = prioridad;
            this.completado = completado;
            this.color = color;
        }
    }
}
