using MauiAppEvento.Models;
using MauiAppEvento.Views;
using Microsoft.Maui.Controls;

namespace MauiAppEvento.Views
{
    public partial class CadastroEvento : ContentPage
    {
        public CadastroEvento()
        {
            InitializeComponent();
        }

        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            if (BindingContext is Evento evento)
            {
                await Navigation.PushAsync(new ResumoEvento(evento));
            }
        }
    }
}
