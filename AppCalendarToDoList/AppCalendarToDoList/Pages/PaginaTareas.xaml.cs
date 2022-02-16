using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.Model;
using AppCalendarToDoList.ViewModels;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTareas : ContentPage
    {
        public List<TareaViewModel> tareas { get; set; }
        public TareaViewModel vm { get; set; }
        public PaginaTareas()
        {
            InitializeComponent();
            vm = new TareaViewModel();
            BindingContext = vm;
            BindableLayout.SetItemsSource(sckTareas, tareas);
            actualizarTareas();
        }

        private async void actualizarTareas()
        {
            List<TareaViewModel> ListaTareas = new List<TareaViewModel>();
            List<Tarea> listaTareasModelo = await getTareasAsync();
            foreach(Tarea tarea in listaTareasModelo)
            {
                ListaTareas.Add(new TareaViewModel(tarea));
            }
            tareas = ListaTareas;
        }

        private async Task<List<Tarea>> getTareasAsync()
        {
            List<Tarea> listaTareas = new List<Tarea>();
            listaTareas = await App.SQLiteDB.getTareasAsync();
            return listaTareas;
        }
        private void btnNuevaTarea_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNuevaTarea());
        }

    }
}