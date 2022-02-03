﻿using System;
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

        public TareaViewModel() { }

        public TareaViewModel(string titulo, DateTime fechaInicio, DateTime fechaFinal, int prioridad, 
            bool completado, List<Objetivo> objetivos)
        {
            this.Titulo = titulo;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
            this.Prioridad = prioridad;
            this.Completado = completado;
            this.Objetivos = objetivos;
        }

    }
}
