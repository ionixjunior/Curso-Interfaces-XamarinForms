using System;
using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploTimePicker : ContentPage
    {
        public ExemploTimePicker()
        {
            InitializeComponent();
            MeuTimePicker.Time = new TimeSpan(10, 0, 0);
        }

        void MeuTimePicker_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                System.Diagnostics.Debug.WriteLine($"A hora selecionada é: {MeuTimePicker.Time}");
            }
        }
    }
}
