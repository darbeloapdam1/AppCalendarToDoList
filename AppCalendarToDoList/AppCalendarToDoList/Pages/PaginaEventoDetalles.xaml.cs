using AppCalendarToDoList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEventoDetalles : ContentPage
    {
        public PaginaEventoDetalles()
        {
            InitializeComponent();
        }
        public PaginaEventoDetalles(DiaEventoViewModel nuevo)
        {
            InitializeComponent();
            this.BindingContext = nuevo;
        }
    }
}