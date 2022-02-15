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
        private void btnGuardarTarea_Clicked(object sender, EventArgs e)
        {
            if (verificar())
            {
                string titulo = entTituloTarea.Text;
                string objetivos = "PRUEBA";
                DateTime fechaInicio = new DateTime(dtpFechaInicio.Date.Day, dtpFechaInicio.Date.Month, dtpFechaInicio.Date.Day);
                DateTime fechaFinal = new DateTime(dtpFechaFinal.Date.Day, dtpFechaFinal.Date.Month, dtpFechaFinal.Date.Day);
                int prioridad = quePrioridad();
                bool completado = false;
                int color = queColor();
                AppCalendarToDoList.Model.Tarea nuevaTarea =
                    new AppCalendarToDoList.Model.Tarea(titulo, objetivos, fechaInicio, fechaFinal, prioridad, completado, color);


            }
        }
        private bool verificar()
        {
            return entTituloTarea.Text != "";
        }

        private int quePrioridad()
        {
            if (rbAlta.IsChecked)
            {
                return 2;
            }
            else if (rbDefault.IsChecked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private int queColor()
        {
            if (rbRosa.IsChecked)
            {
                return 0;
            }
            else if (rbVerde.IsChecked)
            {
                return 1;
            }
            else if (rbRojo.IsChecked)
            {
                return 2;
            }
            else if (rbMorado.IsChecked)
            {
                return 3;
            }
            else if (rbNaranja.IsChecked)
            {
                return 4;
            }
            else if (rbCeleste.IsChecked)
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }
    }
}