using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploButton : ContentPage
    {
        public ExemploButton()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("O botão foi clicado");
        }

        void Button_Pressed(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("O botão foi pressionado");
        }

        void Button_Released(System.Object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("O botão foi solto");
        }
    }
}
