using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppCalendarToDoList.Model
{
    public class Evento
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(100), NotNull]
        public string titulo { get; set; }
        [NotNull]
        public DateTime diaHoraInicio { get; set; }
        [NotNull]
        public DateTime diaHoraFinal { get; set; }
        [NotNull]
        public bool completado { get; set; }
        [NotNull]
        public int repetir { get; set; }
        [NotNull]
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
