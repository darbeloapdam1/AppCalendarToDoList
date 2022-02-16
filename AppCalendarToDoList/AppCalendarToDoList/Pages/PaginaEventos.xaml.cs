using AppCalendarToDoList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.ViewModels;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEventos : ContentPage
    {
        public List<DiaEventoViewModel> eventosDia = new List<DiaEventoViewModel>();
        public List<DateTime> diasMes = new List<DateTime>();
        public DiaEventoViewModel vm { get; set; }

        public PaginaEventos()
        {
            InitializeComponent();
            vm = new DiaEventoViewModel();
            this.BindingContext = vm;
            pckAnio.ItemsSource = getAniosPck();
            pckMes.SelectedIndex = 0;
            pckAnio.SelectedIndex = 22;
            actualizarPaginaAsync();           
        }

        private void btnNuevoEvento_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaNuevoEvento());
        }

        public async Task actualizarPaginaAsync()
        {
            int mesNum = getMesNum(pckMes.Items[pckMes.SelectedIndex]);
            int anio = 2022;//int.Parse(pckAnio.Items[pckAnio.SelectedIndex]);
            DateTime fecha = new DateTime(anio, mesNum, 1);
            diasMes = getDiasMes(fecha);
            eventosDia = await getEventosDiasAsync();
            addDiasGrid(diasMes,eventosDia);
        }

        private async Task<List<DiaEventoViewModel>> getEventosDiasAsync()
        {
            List<DiaEvento> dias = new List<DiaEvento>();
            List<Evento> listaEvento = new List<Evento>();
            listaEvento = await App.SQLiteDB.getEventosAsync();
            List<Tarea> listaTarea = new List<Tarea>();
            listaTarea = await App.SQLiteDB.getTareasAsync();
            for(int i = 0; i < diasMes[diasMes.Count - 1].Day; i++)
            {
                DiaEvento dia = new DiaEvento(new DateTime(2022,getMesNum(pckMes.Items[pckMes.SelectedIndex]), i + 1));
                dia.Eventos = listaEvento;
                dia.Tareas = listaTarea;
                dias.Add(dia);
            }
            List<DiaEventoViewModel> listaEventos = new List<DiaEventoViewModel>();
            foreach(DiaEvento evento in dias)
            {
                listaEventos.Add(new DiaEventoViewModel(evento));
            }
            return listaEventos;
        }

        private List<DateTime> getDiasMes(DateTime fecha)
        {
            List<DateTime> fechaDia = new List<DateTime>();
            for(int i = 0; i < DateTime.DaysInMonth(fecha.Year, fecha.Month); i++)
            {
                fechaDia.Add(new DateTime(fecha.Year, fecha.Month, i + 1));
            }
            return fechaDia;
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

        private void addDiasGrid(List<DateTime> diasMes,List<DiaEventoViewModel> eventosDia)
        {
            //clearGrid();
            grdEventos.RowDefinitions.Add(new RowDefinition { Height = new GridLength(40) });
            for (int i = 0; i < diasMes.Count; i++)
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
                int fila = grdEventos.RowDefinitions.Count;
                grdEventos.Children.Add(crearGridEvento(diasMes[i], eventosDia[i]), columna, fila);
                grdEventos.RowDefinitions.Add(new RowDefinition { Height = new GridLength(10) });
            }
            grdEventos.RowDefinitions.Add(new RowDefinition { Height = new GridLength(50) });
        }

        private Grid crearGridEvento(DateTime fecha, DiaEventoViewModel diaEvento)
        {
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(30) },
                    new RowDefinition { Height = new GridLength(80) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(160) }
                }
            };

            grid.Children.Add(new Frame
            {
                CornerRadius = 10,
                BackgroundColor = Color.Transparent,
                BorderColor = Color.White,
            }, 0, 1, 0, 2);


            grid.Children.Add(new Label
            {
                Text = fecha.DayOfWeek.ToString(),
                FontSize = 24,
                Margin = new Thickness(10, 0, 0, 0)
            }, 0, 0);


            ImageButton imgButton = new ImageButton
            {
                Source = "puntos.png",
                BackgroundColor = Color.Transparent,
                Margin = new Thickness(130, 10, 0, 0),

            };
            imgButton.Clicked += (sender, args) => Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new PaginaEventoDetalles(diaEvento));

            grid.Children.Add(imgButton);

            grid.Children.Add(new Label
            {
                Text = fecha.Day.ToString("D2"),
                FontSize = 30,
                TextColor = Color.White,
                Margin = new Thickness(20, 0, 120, 0)
            }, 0, 1);

            grid.Children.Add(new Line
            {
                BackgroundColor = Color.Red,
                Margin = new Thickness(45, 10, 114, 10)
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = diaEvento.NumEventos,
                Margin = new Thickness(60, 15, 0, 0)
            }, 0, 1);

            grid.Children.Add(new Label
            {
                Text = diaEvento.NumTareas,
                Margin = new Thickness(60, 45, 0, 0)
            }, 0, 1);

            var clickRecoginizer = new ClickGestureRecognizer();
            clickRecoginizer.SetBinding(ClickGestureRecognizer.CommandProperty, "TappedCommandAction");
            grid.GestureRecognizers.Add(clickRecoginizer);

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "TappedCommandAction");
            grid.GestureRecognizers.Add(tapGestureRecognizer);
            return grid;
        }

        private void clearGrid()
        {
            RowDefinitionCollection filas = grdEventos.RowDefinitions;
            for (int i = 0; i < filas.Count; i++)
            {
                grdEventos.RowDefinitions.RemoveAt(0);
            }
            grdEventos.Children.Clear();
        }

        private void pckMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPaginaAsync();
        }

        private void pckAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPaginaAsync();
        }
    }
}