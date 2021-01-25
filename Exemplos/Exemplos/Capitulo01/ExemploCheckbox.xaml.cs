using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplos.Capitulo01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExemploCheckbox : ContentPage
    {
        public ExemploCheckbox()
        {
            InitializeComponent();
        }

        void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
    }
}