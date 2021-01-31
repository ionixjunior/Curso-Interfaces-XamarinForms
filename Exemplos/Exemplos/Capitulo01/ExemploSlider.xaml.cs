using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploSlider : ContentPage
    {
        public ExemploSlider()
        {
            InitializeComponent();
        }

        void Slider_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Novo valor: {e.NewValue} - Antigo valor: {e.OldValue}");
        }
    }
}
