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
                DateTime diaHoraInicio = new DateTime(2022, 1, 19, tpEmpieza.Time.Hours, tpEmpieza.Time.Minutes, 0);
                DateTime diaHoraFinal = new DateTime(2022, 1, 19, tpTermina.Time.Hours, tpTermina.Time.Minutes, 0);

                AppCalendarToDoList.Model.Evento nuevoEvento = new AppCalendarToDoList.Model.Evento(titulo, diaHoraInicio, diaHoraFinal, false);

            
            }
        }

        private bool verificar()
        {
            return entTituloEvento.Text != "";
        }
    }
}