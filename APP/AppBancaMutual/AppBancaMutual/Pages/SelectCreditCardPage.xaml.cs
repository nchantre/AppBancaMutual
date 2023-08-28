using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancaMutual.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectCreditCardPage : ContentPage
	{
		public SelectCreditCardPage ()
		{
			InitializeComponent ();
		}

	    private void AddCardClick(object sender, EventArgs e)
	    {
	       // Navigation.PushModalAsync(new AddNewCardPage(),true);
	    }

	    private void BackButton(object sender, EventArgs e)
	    {
	        Navigation.PopAsync(true);
	    }

	    private async void ContinueOrderButton(object sender, EventArgs e)
	    {
	      await  Navigation.PushAsync(new SuccessPage());
	    }
	}
}