using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploTimePicker : ContentPage
    {
        public ExemploTimePicker()
        {
            InitializeComponent();

            MeuTimePicker.Time = new TimeSpan(10, 0, 0);

            MeuTimePicker.PropertyChanged += MeuTimePicker_PropertyChanged;
        }

        private void MeuTimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                System.Diagnostics.Debug.WriteLine($"A hora selecionada foi {MeuTimePicker.Time}");
            }
        }
    }
}
