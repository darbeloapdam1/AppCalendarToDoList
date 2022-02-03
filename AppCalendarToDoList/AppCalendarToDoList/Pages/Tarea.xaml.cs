using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCalendarToDoList.ViewModels;

namespace AppCalendarToDoList.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]   
    public partial class Tarea : ContentPage
    {
        TareaViewModel ViewModel;
        public Tarea()
        {
            InitializeComponent();
            ViewModel = new TareaViewModel();
            BindingContext = ViewModel;
        }
    }
}