using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace Exemplos
{
    public partial class CapituloPage : ContentPage
    {
        public CapituloPage(string namespaceDoCapitulo)
        {
            InitializeComponent();
            Title = namespaceDoCapitulo;

            var exemplosDoCapitulo = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.Namespace == namespaceDoCapitulo)
                .ToList();

            ListaDosExemplos.ItemsSource = exemplosDoCapitulo;
            ListaDosExemplos.ItemTapped += OnItemTapped;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var objetoParaInstanciar = $"{e.Item}, Exemplos";
            var tipoDoObjeto = Type.GetType(objetoParaInstanciar);
            var telaExemplo = Activator.CreateInstance(tipoDoObjeto) as Page;
            await Navigation.PushAsync(telaExemplo);
            ListaDosExemplos.SelectedItem = null;
        }
    }
}
