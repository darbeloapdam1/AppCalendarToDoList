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
        string diaSemana, dia, mes;
        public DiaEvento(DateTime fecha)
        {
            this.fecha = fecha;
            this.dia = "" + fecha.Day;
            this.diaSemana = fecha.DayOfWeek.ToString();
            Grid = crearGridDia();
        }

        public Grid Grid
        {
            get { return grid; }
            set
            {
                this.grid = value;
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
                Text = "Ningún evento",
                Margin = new Thickness(60, 15, 0, 0)
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = "Ninguna tarea",
                Margin = new Thickness(60, 45, 0, 0)
            }, 0, 1);

            return grid;
        }

        

    }
}
