using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploDatePicker : ContentPage
    {
        public ExemploDatePicker()
        {
            InitializeComponent();

            MeuDatePicker.Date = new DateTime(2020, 11, 11);
            MeuDatePicker.MinimumDate = new DateTime(2020, 11, 5);
            MeuDatePicker.MaximumDate = new DateTime(2020, 11, 15);

            MeuDatePicker.DateSelected += MeuDatePicker_DateSelected;
        }

        private void MeuDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"A data selecionada é {e.NewDate} e a antiga é {e.OldDate}");
        }
    }
}
