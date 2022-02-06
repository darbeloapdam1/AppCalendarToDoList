using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.Pages;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaTareas : FlyoutPage
    {
        public PaginaTareas()
        {
            InitializeComponent();
            
            actualizarTareas();
        }

        private void actualizarTareas()
        {
            foreach(Tarea tarea in getTareas())
            {
                grdTareas.RowDefinitions.Add(new RowDefinition { Height = new GridLength(180) });
                int numFila = grdTareas.RowDefinitions.Count;
                //grdTareas.Children.Add(tarea,0,numFila);
            }
        }

        private List<Tarea> getTareas()
        {
            List<Tarea> listaTareas = new List<Tarea>();

            return listaTareas;
        }
        private void btnNuevaTarea_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaNuevaTarea());
            IsPresented = false;
        }
    }
}