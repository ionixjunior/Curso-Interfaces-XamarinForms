using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exemplos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var namespacesDosCapitulos = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.Namespace.Contains("Capitulo"))
                .Select(x => x.Namespace)
                .Distinct();

            ListaDosCapitulos.ItemsSource = namespacesDosCapitulos;
            ListaDosCapitulos.ItemTapped += OnItemTapped;
        }

        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new CapituloPage(e.Item.ToString()));
            ListaDosCapitulos.SelectedItem = null;
        }
    }
}
