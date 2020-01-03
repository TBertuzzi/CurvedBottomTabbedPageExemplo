using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsCurvedBottomNavigation;
using Xamarin.Forms;

namespace CurvedBottomTabbedPageExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : CurvedBottomTabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new PaginaTeste("Acontecendo Ao Vivo")
            {
                Title = "Ao Vivo",
                IconImageSource = "aovivo"
            });
            this.Children.Add(new PaginaTeste("Eventos de Hoje")
            {
                Title = "Evento",
                IconImageSource = "evento"
            });
            this.Children.Add(new PaginaTeste("Informações")
            {
                Title = "Info",
                IconImageSource = "info"
            });
            this.Children.Add(new PaginaTeste("Temas de Hoje")
            {
                Title = "Temas",
                IconImageSource = "temas"
            });

            this.NavigateToPage = new PaginaTeste("Programação");
        }
    }
}
