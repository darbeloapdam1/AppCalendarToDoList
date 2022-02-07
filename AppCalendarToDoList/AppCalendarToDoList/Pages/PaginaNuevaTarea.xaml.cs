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
    public partial class PaginaNuevaTarea : ContentPage
    {
        public PaginaNuevaTarea()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            entTituloTarea.Focus();
        }

    }
}