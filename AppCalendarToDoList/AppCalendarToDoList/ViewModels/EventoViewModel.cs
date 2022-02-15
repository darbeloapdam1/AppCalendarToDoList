using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using AppCalendarToDoList.Model;

namespace AppCalendarToDoList.ViewModels
{
    public class EventoViewModel : INotifyPropertyChanged
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
                if (value != _titulo)
                {
                    _titulo = value;
                    OnPropertyChanged("Titulo");
                }
            }
        }

        DateTime _diaHoraInicio;
        public DateTime DiaHoraInicio
        {
            get { return _diaHoraInicio; }
            set
            {
                if (value != _diaHoraInicio)
                {
                    _diaHoraInicio = value;
                    OnPropertyChanged("DiaHoraInicio");
                }
            }
        }

        DateTime _diaHoraFinal;
        public DateTime DiaHoraFinal
        {
            get { return _diaHoraFinal; }
            set
            {
                if (value != _diaHoraFinal)
                {
                    _diaHoraFinal = value;
                    OnPropertyChanged("DiaHoraFinal");
                }
            }
        }

        bool _completado;
        public bool Completado
        {
            get { return _completado; }
            set
            {
                if (value != _completado)
                {
                    _completado = value;
                    OnPropertyChanged("Completado");
                }
            }
        }

        int _repetir;
        public int Repetir
        {
            get { return _repetir; }
            set
            {
                if (value != _repetir)
                {
                    _repetir = value;
                    OnPropertyChanged("Repetir");
                }
            }

        }

        int _aviso;
        public int Aviso
        {
            get { return _aviso; }
            set
            {
                if(value != _aviso)
                {
                    _aviso = value;
                    OnPropertyChanged("Aviso");
                }
            }
        }

        public EventoViewModel() { }

        public EventoViewModel(string titulo, DateTime diaHoraInicio, DateTime diaHoraFinal, 
            bool completado, int[] avisoRepetir)
        {
            this.Titulo = titulo;
            this.DiaHoraInicio = diaHoraInicio;
            this.DiaHoraFinal = diaHoraFinal;
            this.Completado = completado;
            this.Repetir = avisoRepetir[1];
            this.Aviso = avisoRepetir[0];
        }

        public EventoViewModel(Evento evento)
        {
            this.Titulo = evento.titulo;
            this.DiaHoraFinal = evento.diaHoraFinal;
            this.DiaHoraInicio = evento.diaHoraInicio;
            this.Completado = evento.completado;
        }

    }
}
