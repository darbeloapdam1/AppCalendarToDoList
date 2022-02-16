using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AppCalendarToDoList.Model;

namespace AppCalendarToDoList.ViewModels
{
    public class TareaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if(value != _titulo)
                {
                    _titulo = value;
                    OnPropertyChanged("Titulo");
                }
            }
        }

        DateTime _fechaInicio;
        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set
            {
                if(value != _fechaInicio)
                {
                    _fechaInicio = value;
                    OnPropertyChanged("FechaInicio");
                }
            }
        }

        DateTime _fechaFinal;
        public DateTime FechaFinal
        {
            get { return _fechaFinal; }
            set
            {
                if(value != _fechaFinal)
                {
                    _fechaFinal = value;
                    OnPropertyChanged("FechaFinal");
                }
            }
        }

        int _prioridad;
        public int Prioridad
        {
            get { return _prioridad; }
            set
            {
                if(value != _prioridad)
                {
                    _prioridad = value;
                    OnPropertyChanged("Prioridad");
                }
            }
        }

        bool _completado;
        public bool Completado
        {
            get { return _completado; }
            set
            {
                if(value != _completado)
                {
                    _completado = value;
                    OnPropertyChanged("Completado");
                }
            }
        }

        List<Objetivo> _objetivos;
        public List<Objetivo> Objetivos
        {
            get { return _objetivos; }
            set
            {
                if(value != _objetivos)
                {
                    _objetivos = value;
                    OnPropertyChanged("Objetivos");
                }
            }
        }

        int _color;
        public int Color
        {
            get { return _color; }
            set
            {
                if (value != _color)
                {
                    _color = value;
                    OnPropertyChanged("Color");
                }
            }
        }

        public TareaViewModel() { }

        public TareaViewModel(string titulo, DateTime fechaInicio, DateTime fechaFinal, int prioridad, 
            bool completado, List<Objetivo> objetivos, int color)
        {
            this.Titulo = titulo;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.Prioridad = prioridad;
            this.Completado = completado;
            this.Objetivos = objetivos;
            this.Color = color;
        }

        public TareaViewModel(Tarea tarea)
        {
            this.Titulo = tarea.titulo;
            this.FechaInicio = tarea.fechaInicio;
            this.FechaFinal = tarea.fechaFinal;
            this.Prioridad = tarea.prioridad;
            this.Completado = tarea.completado;
            this.Color = tarea.color;
            this.Objetivos = getObjetivosTareaLista(tarea.objetivos);
        }

        //Parsea a una lista de Model.Objetivo un string
        private List<Objetivo> getObjetivosTareaLista(string objetivos){
            List<Objetivo> lista = new List<Objetivo>();
            string[] objsString = objetivos.Split(';');
            for(int i = 0; i < objsString.Length - 1; i++){
                string[] objFinal = objsString[i].Split(',');
                lista.Add(new Objetivo(objFinal[0], bool.Parse(objFinal[1])));
            }
            return lista;
        }

    }
}
