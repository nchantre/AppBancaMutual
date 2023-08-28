using System;
using Xamarin.Forms.Xaml;


namespace AppBancaMutual.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

	    private async void LoginButtonClick(object sender, EventArgs e)
	    {
	      await  Navigation.PushAsync(new HomeTabbedPage());
	    }
	}
}