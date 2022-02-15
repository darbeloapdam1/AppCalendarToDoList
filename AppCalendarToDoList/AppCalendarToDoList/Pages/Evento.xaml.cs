using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.ViewModels;


namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Evento : ContentPage
    {
        EventoViewModel ViewModel;
        private string titulo;
        private DateTime diaHoraInicio;
        private DateTime diaHoraFinal;
        private bool v;

        public Evento()
        {
            InitializeComponent();
            ViewModel = new EventoViewModel();
            BindingContext = ViewModel;
		}

        public Evento(string titulo, DateTime diaHoraInicio, DateTime diaHoraFinal, bool v)
        {
            this.titulo = titulo;
            this.diaHoraInicio = diaHoraInicio;
            this.diaHoraFinal = diaHoraFinal;
            this.v = v;
        }
    }
}