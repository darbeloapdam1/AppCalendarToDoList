using System;
using System.Collections.Generic;
using System.Text;
using AppCalendarToDoList.ViewModels;
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


        public Evento() { }
        public Evento(string titulo, DateTime diaHoraInicio, DateTime diaHoraFinal, bool completado)
        {
            this.titulo = titulo;
            this.diaHoraInicio = diaHoraInicio;
            this.diaHoraFinal = diaHoraFinal;
            this.completado = completado;
        }

        public Evento(EventoViewModel eventVM)
        {
            this.titulo = eventVM.Titulo;
            this.diaHoraFinal = eventVM.DiaHoraFinal;
            this.diaHoraInicio = eventVM.DiaHoraInicio;
            this.completado = eventVM.Completado;
        }

    }
}
