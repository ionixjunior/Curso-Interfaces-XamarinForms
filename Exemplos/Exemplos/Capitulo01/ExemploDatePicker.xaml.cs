using System;
using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploDatePicker : ContentPage
    {
        public ExemploDatePicker()
        {
            InitializeComponent();

            var data = new DateTime(2021, 1, 10);
            MeuDatePicker.Date = data;
            MeuDatePicker.MinimumDate = data.AddDays(-1);
            MeuDatePicker.MaximumDate = data.AddDays(1);
        }

        void MeuDatePicker_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Novo valor: {e.NewDate} - Valor antigo: {e.OldDate}");
        }
    }
}
