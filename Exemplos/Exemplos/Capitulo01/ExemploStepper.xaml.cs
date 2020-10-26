using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exemplos.Capitulo01
{
	public partial class ExemploStepper : ContentPage
	{
		public ExemploStepper()
		{
			InitializeComponent();
		}

		private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			Console.WriteLine($"O novo valor é: {e.NewValue}");
		}
	}
}