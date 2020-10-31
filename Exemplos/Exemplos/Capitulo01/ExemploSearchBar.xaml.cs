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
	public partial class ExemploSearchBar : ContentPage
	{
		public ExemploSearchBar()
		{
			InitializeComponent();
		}

		void SearchBar_SearchButtonPressed(object sender, EventArgs e)
		{
			
		}
	}
}