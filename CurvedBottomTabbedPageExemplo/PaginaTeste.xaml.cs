using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CurvedBottomTabbedPageExemplo
{
    public partial class PaginaTeste : ContentPage
    {
        public PaginaTeste(string descricao)
        {
            InitializeComponent();

            lblPagina.Text = $"Pagina de Teste {descricao} ";
        }
    }
}
