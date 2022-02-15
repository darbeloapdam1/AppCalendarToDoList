using AppCalendarToDoList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppCalendarToDoList.ViewModels
{
    public class DiaEventoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        DateTime _fecha;
        List<Evento> _eventos;
        List<Tarea> _tareas;
        string _diaSemana;
        string _dia;
        string _mes;

        public DateTime Fecha
        {
            get { return _fecha; }
            set
            {
                _fecha = value;
                OnPropertyChanged("Fecha");
            }
        }

        public List<Evento> Eventos
        {
            get { return _eventos; }
            set
            {
                _eventos = value;
                OnPropertyChanged("Eventos");
            }
        }

        public List<Tarea> Tareas
        {
            get { return _tareas; }
            set
            {
                _tareas = value;
                OnPropertyChanged("Tareas");
            }
        }

        public string DiaSemana
        {
            get { return _diaSemana; }
            set
            {
                _diaSemana = value;
                OnPropertyChanged("DiaSemana");
            }
        }

        public string Dia
        {
            get { return _dia; }
            set
            {
                _dia = value;
                OnPropertyChanged("Dia");
            }
        }

        public string Mes
        {
            get { return _mes; }
            set
            {
                _mes = value;
                OnPropertyChanged("Mes");
            }
        }

        public string NumEventos
        {
            get
            {
                try
                {
                    if (Eventos == null)
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return "Ningún evento";
                }
            }
        }

        public string NumTareas
        {
            get
            {
                try
                {
                    if (Tareas == null)
                    {
                        return "Ninguna tarea";
                    }
                    else
                    {
                        if (Tareas.Count == 0)
                        {
                            return "Ninguna tarea";
                        }
                        else if (Tareas.Count == 1)
                        {
                            return "1 tarea";
                        }
                        else
                        {
                            return Tareas.Count + " tareas";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return "Ninguna tarea";
                }
            }
        }
            
        public DiaEventoViewModel() { }
        public DiaEventoViewModel(DiaEvento dia)
        {
            Fecha = dia.Fecha;
            Eventos = dia.Eventos;
            Tareas = dia.Tareas;
            DiaSemana = dia.DiaSemana;
            Dia = dia.Dia;
            Mes = dia.Mes;
        }

        public DiaEventoViewModel(DateTime fecha)
        {
            Fecha = fecha;
            getAtributesBd();
        }

        private void getAtributesBd()
        {

        }
    }
}
