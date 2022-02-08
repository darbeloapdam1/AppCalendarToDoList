using AppCalendarToDoList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEventos : ContentPage
    {
        public PaginaEventos()
        {
            InitializeComponent();
            pckAnio.ItemsSource = getAniosPck();
            pckMes.SelectedIndex = 0;
            pckAnio.SelectedIndex = 22;
            actualizarPagina();
        }

        private void btnNuevoEvento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNuevoEvento());
        }

        public void actualizarPagina()
        {
            int prueba = pckAnio.SelectedIndex;
            int mesNum = getMesNum(pckMes.Items[pckMes.SelectedIndex]);
            int anio = 2022;//int.Parse(pckAnio.Items[pckAnio.SelectedIndex]);
            DateTime fecha = new DateTime(anio, mesNum,1);
            List<DiaEvento> diasMes = getDiasMes(fecha);
            addDiasGrid(diasMes);
        }

        private List<DiaEvento> getDiasMes(DateTime fecha)
        {
            DateTime fechaDia = fecha;
            List<DiaEvento> lista = new List<DiaEvento>();
            for(int i = 0; i < DateTime.DaysInMonth(fecha.Year, fecha.Month); i++)
            {
                lista.Add(new DiaEvento(fechaDia));
                fechaDia = fechaDia.AddDays(1);
            }
            return lista;
        }

        public static int getMesNum(string mes)
        {
            if (mes.Equals("Enero"))
            {
                return 1;
            }else if (mes.Equals("Febrero"))
            {
                return 2;
            }else if (mes.Equals("Marzo"))
            {
                return 3;
            }else if (mes.Equals("Abril"))
            {
                return 4;
            }else if (mes.Equals("Mayo"))
            {
                return 5;
            }else if (mes.Equals("Junio"))
            {
                return 6;
            }else if (mes.Equals("Julio"))
            {
                return 7;
            }else if (mes.Equals("Agosto"))
            {
                return 8;
            }else if (mes.Equals("Septiembre"))
            {
                return 9;
            }else if (mes.Equals("Octubre"))
            {
                return 10;
            }else if (mes.Equals("Noviembre"))
            {
                return 11;
            }else if (mes.Equals("Diciembre"))
            {
                return 10;
            }
            return 0;
        }

        private List<int> getAniosPck()
        {
            List<int> lista = new List<int>();

            for (int i = 2000; i < 2025; i++)
            {
                lista.Add(i);
            }

            return lista;
        }

        private void addDiasGrid(List<DiaEvento> dias)
        {
            RowDefinitionCollection filas = grdEventos.RowDefinitions;
            for(int i = 0; i < filas.Count; i++)
            {
                grdEventos.RowDefinitions.RemoveAt(0);
            }
            grdEventos.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            for (int i = 0; i < dias.Count; i++)
            {
                int columna = 0;
                if(i % 2 == 0 && i != 0)
                {
                    columna = 0;
                    grdEventos.RowDefinitions.Add(new RowDefinition { Height = new GridLength(110) });
                }
                else
                {
                    if(i != 0)
                    {
                        columna = 2;
                    }                   
                }
                grdEventos.Children.Add(dias[i].Grid, columna, grdEventos.RowDefinitions.Count);
                
            }
        }

        private void pckMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPagina();
        }

        private void pckAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPagina();
        }
    }
}