using AppCalendarToDoList.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace AppCalendarToDoList.Model
{
    public class DiaEvento
    {
        DateTime fecha;
        List<EventoViewModel> eventos;
        List<TareaViewModel> tareas;
        Grid grid;
        string diaSemana, dia, mes, numEventos, numTareas;
        public DiaEvento(DateTime fecha)
        {
            this.fecha = fecha;
            this.dia = "" + fecha.Day;
            this.diaSemana = fecha.DayOfWeek.ToString();
            NumEventos = getNumEventos();
            NumTareas = getNumTareas();
            Grid = crearGridDia();
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

        public Grid Grid
        {
            get { return grid; }
            set
            {
                this.grid = value;
            }
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
                return "Ningún evento";
            }
        }

        private string getNumTareas()
        {
            try
            {
                if(tareas == null)
                {
                    return "Ninguna tareaa";
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
                return "Ninguna tarea";
            }
        }

        private Grid crearGridDia()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(30) },
                    new RowDefinition { Height = new GridLength(80) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(160) }
                }
            };

            grid.Children.Add(new Frame
            {
                CornerRadius = 10,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
            }, 0, 0);

            grid.Children.Add(new Label
            {
                Text = diaSemana,
                FontSize = 24,
                Margin = new Thickness(10, 0, 0, 0)
            }, 0, 0);

            grid.Children.Add(new Label
            {
                Text = dia,
                FontSize = 32,
                TextColor = Color.White,
                Margin = new Thickness(10, 0, 100, 0)
            }, 1, 0);

            grid.Children.Add(new Line
            {
                BackgroundColor = Color.Red,
                Margin = new Thickness(35, 10, 124, 10)
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = NumEventos,
                Margin = new Thickness(60, 15, 0, 0)
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = NumTareas,
                Margin = new Thickness(60, 45, 0, 0)
            }, 0, 1);

            return grid;
        }

        

    }
}
