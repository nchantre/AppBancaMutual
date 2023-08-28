using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancaMutual.Pages;


namespace AppBancaMutual.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterPage 
	{
		public RegisterPage ()
		{
		   

            InitializeComponent ();
		  
		}
	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();
	       await RegisterLayout.TranslateTo(0, 0);

        }
        private async void RegisteruButtonClick(object sender, EventArgs e)
	    {
	      await  Navigation.PushAsync(new HomeTabbedPage());
	    }
    }
    
}
