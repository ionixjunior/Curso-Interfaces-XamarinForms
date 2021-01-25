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
    public partial class ExemploRadioButton : ContentPage
    {
        public ExemploRadioButton()
        {
            InitializeComponent();
        }

        void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
    }
}