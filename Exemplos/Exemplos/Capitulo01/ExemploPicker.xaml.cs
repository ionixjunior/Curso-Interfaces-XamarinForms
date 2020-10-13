using System;
using System.Collections.Generic;
using System.Linq;
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
                new Item { Nome = "Opção A" },
                new Item { Nome = "Opção B" },
                new Item { Nome = "Opção C" }
            };

            MeuPicker.ItemsSource = itens;

            //MeuPicker.SelectedIndex = 2;
            MeuPicker.SelectedItem = itens.Last();
        }

        void MeuPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"O índice selecionado foi {MeuPicker.SelectedIndex} com o valor {MeuPicker.SelectedItem}");
        }
    }

    public class Item
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
