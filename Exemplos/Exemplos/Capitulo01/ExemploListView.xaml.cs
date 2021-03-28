using System;
using Exemplos.Models;
using Exemplos.ViewModels;
using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploListView : ContentPage
    {

        public ExemploListView()
        {
            InitializeComponent();

            BindingContext = new ExemploListViewModel();
        }

        private void AoClicarNaAcao1(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem
                && menuItem.CommandParameter is ItemLista itemLista)
            {
                System.Diagnostics.Debug.WriteLine($"Ação 1; Item {itemLista.Nome}, {itemLista.Profissao}, {itemLista.Passatempo}");
            }
        }

        private void AoClicarNaAcao2(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem
                && menuItem.CommandParameter is ItemLista itemLista)
            {
                System.Diagnostics.Debug.WriteLine($"Ação 2; Item {itemLista.Nome}, {itemLista.Profissao}, {itemLista.Passatempo}");
            }
        }

        private void AoSelecionarItem(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is ItemLista itemLista)
                System.Diagnostics.Debug.WriteLine($"Item selecionado: {itemLista.Nome}, {itemLista.Profissao}, {itemLista.Passatempo}");
        }
    }
}
