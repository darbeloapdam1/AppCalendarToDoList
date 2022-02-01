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
        public List<int> avisoRepetir { get; set; } 

    }
}
