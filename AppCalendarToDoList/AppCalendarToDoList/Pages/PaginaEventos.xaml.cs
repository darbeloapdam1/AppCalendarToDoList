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
    public partial class PaginaEventos : ContentPage
    {
        public PaginaEventos()
        {
            InitializeComponent();
            
        }

        private void btnNuevoEvento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNuevoEvento());
        }
        
    }
}