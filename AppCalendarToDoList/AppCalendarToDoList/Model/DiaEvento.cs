using AppCalendarToDoList.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using AppCalendarToDoList.Pages;

namespace AppCalendarToDoList.Model
{
    public class DiaEvento
    {
        DateTime fecha;
        List<Evento> eventos;
        List<Tarea> tareas;
        string diaSemana, dia, mes;
        public DiaEvento(DateTime fecha)
        {
            this.fecha = fecha;
            this.dia = fecha.Day.ToString("D2");
            this.diaSemana = fecha.DayOfWeek.ToString();
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public List<Evento> Eventos
        {
            get { return eventos; }
            set { eventos = value; }
        }

        public List<Tarea> Tareas
        {
            get { return tareas; }
            set { tareas = value; }
        }

        public String DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }


    }
}
