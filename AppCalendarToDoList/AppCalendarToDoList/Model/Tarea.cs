using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendarToDoList.Model
{
    public class Tarea
    {
        public string titulo { get; set; }
        public List<Objetivo> objetivos { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public int prioridad { get; set; }
        public bool completado { get; set; }

        public Tarea(string titulo, List<Objetivo> objetivos, DateTime fechaInicio, DateTime fechaFinal, 
            int prioridad, bool compleatdo)
        {
            this.titulo = titulo;
            this.objetivos = objetivos;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.prioridad = prioridad;
            this.completado = completado;
        }
    }
}
