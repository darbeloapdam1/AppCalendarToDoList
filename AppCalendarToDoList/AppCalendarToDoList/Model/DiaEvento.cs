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
        string diaSemana, dia, mes, numEventos, numTareas;
        public DiaEvento(DateTime fecha)
        {
            this.fecha = fecha;
            this.dia = fecha.Day.ToString("D2");
            this.diaSemana = fecha.DayOfWeek.ToString();
            NumEventos = getNumEventos();
            NumTareas = getNumTareas();
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public List<EventoViewModel> Eventos
        {
            get { return eventos; }
            set { eventos = value; }
        }

        public List<TareaViewModel> Tareas
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

        public string NumEventos
        {
            get { return numEventos; }
            set { numEventos = value; }
        }

        public string NumTareas
        {
            get { return numTareas; }
            set { numTareas = value; }
        }

        private string getNumEventos()
        {
            try
            {
                if (eventos == null)
                {
                    return "Ningún evento";
                }
                else
                {
                    if (Eventos.Count == 0)
                    {
                        return "Ningún evento";
                    }
                    else if (Eventos.Count == 1)
                    {
                        return "1 evento";
                    }
                    else
                    {
                        return Eventos.Count + " eventos";
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return "Ningún evento";
            }
        }

        private string getNumTareas()
        {
            try
            {
                if(tareas == null)
                {
                    return "Ninguna tarea";
                }
                else
                {
                    if(Tareas.Count == 0)
                    {
                        return "Ninguna tarea";
                    }else if(Tareas.Count == 1)
                    {
                        return "1 tarea";
                    }
                    else
                    {
                        return tareas.Count + " tareas";
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                return "Ninguna tarea";
            }
        }       

    }
}
