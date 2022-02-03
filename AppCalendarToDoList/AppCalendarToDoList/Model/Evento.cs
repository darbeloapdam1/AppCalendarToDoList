using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendarToDoList.Model
{
    public class Evento
    {
        public string titulo { get; set; }
        public DateTime diaHoraInicio { get; set; }
        public DateTime diaHoraFinal { get; set; }
        public bool completado { get; set; }
        public int repetir { get; set; } 

        public int aviso { get; set; }

        public Evento(string titulo, DateTime diaHoraInicio, DateTime diaHoraFinal, bool completado, List<int> avisoRepetir)
        {
            this.titulo = titulo;
            this.diaHoraInicio = diaHoraInicio;
            this.diaHoraFinal = diaHoraFinal;
            this.completado = completado;
            this.repetir = avisoRepetir[1];
            this.aviso = avisoRepetir[0];
        }

    }
}
