using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendarToDoList.Model
{
    public class Objetivo
    {
        public string descripcion { get; set; }
        public bool completado { get; set; }

        public Objetivo(string descripcion, bool completado)
        {
            this.descripcion = descripcion;
            this.completado = completado;
        }
    }
}
