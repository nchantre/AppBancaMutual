using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancaMutual.ModalPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewAddressPage : ContentPage
	{
		public AddNewAddressPage ()
		{
			InitializeComponent ();
		}

	    private void ClosePageClick(object sender, EventArgs e)
	    {
	        Navigation.PopModalAsync();
	    }
	}
}