using Xamarin.Forms;

namespace Exemplos.Capitulo01
{
    public partial class ExemploWebView : ContentPage
    {
        public ExemploWebView()
        {
            InitializeComponent();
        }

        void WebView_Navigated(System.Object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Navegou para {e.Url}");
        }

        void WebView_Navigating(System.Object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Vai navegar para {e.Url}");
        }
    }
}
