using System.Collections.Generic;
using System.Linq;
using Exemplos.Models;
using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploPicker : ContentPage
    {
        public ExemploPicker()
        {
            InitializeComponent();

            var itens = new List<Item>
            {
                new Item() { Name = "Item 1" },
                new Item() { Name = "Item 2" },
                new Item() { Name = "Item 3" }
            };

            MeuPicker.ItemsSource = itens;

            //MeuPicker.SelectedIndex = 2;
            MeuPicker.SelectedItem = itens.Last();
        }

        void MeuPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Índice selecionado {MeuPicker.SelectedIndex} - Item selecionado {MeuPicker.SelectedItem}");
        }
    }
}
