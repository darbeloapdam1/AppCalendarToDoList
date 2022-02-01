using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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

        List<int> _avisoRepetir;
        public List<int> AvisoRepetir
        {
            get { return _avisoRepetir; }
            set
            {
                if (value != _avisoRepetir)
                {
                    _avisoRepetir = value;
                    OnPropertyChanged("AvisoRepetir");
                }
            }

        }
    }
}
