using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCalendarToDoList.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNuevoEvento : ContentPage
    {
        public DateTime fecha;
        public PaginaNuevoEvento()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            entTituloEvento.Focus();
        }

        private void btnGuardarEvento_Clicked(object sender, EventArgs e)
        {
            if (verificar())
            {
                string titulo = entTituloEvento.Text;
                DateTime diaHoraInicio = new DateTime(fecha.Year, fecha.Month, fecha.Day, tpEmpieza.Time.Hours, tpEmpieza.Time.Minutes, 0);
                DateTime diaHoraFinal = new DateTime(fecha.Year, fecha.Month, fecha.Day, tpTermina.Time.Hours, tpTermina.Time.Minutes, 0);

                Model.Evento nuevoEvento = new Model.Evento(titulo, diaHoraInicio, diaHoraFinal, false);
                
                Navigation.PopAsync();
            }
        }

        private bool verificar()
        {
            return entTituloEvento.Text != "";
        }
    }
}