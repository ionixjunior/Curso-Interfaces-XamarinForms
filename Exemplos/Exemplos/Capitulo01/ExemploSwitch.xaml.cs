using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploSwitch : ContentPage
    {
        public ExemploSwitch()
        {
            InitializeComponent();
        }

        void Switch_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"O valor foi alterado para {e.Value}");
        }
    }
}
