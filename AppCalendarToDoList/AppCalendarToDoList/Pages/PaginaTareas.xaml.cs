using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.Pages;
using AppCalendarToDoList.ViewModels;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTareas : ContentPage
    {
        public PaginaTareas()
        {
            InitializeComponent();
            
            actualizarTareas();
        }

        private void actualizarTareas()
        {
            List<TareaViewModel> tareas = new List<TareaViewModel>();
            
        }

        private List<Tarea> getTareas()
        {
            List<Tarea> listaTareas = new List<Tarea>();

            return listaTareas;
        }
        private void btnNuevaTarea_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNuevaTarea());
        }

    }
}