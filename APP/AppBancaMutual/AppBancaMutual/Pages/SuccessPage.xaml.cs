using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancaMutual.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuccessPage : ContentPage
    {
        public SuccessPage()
        {
            InitializeComponent();
        }

        private async void ContinueClick(object sender, EventArgs e)
        {
            //.Current.MainPage = new HomeTabbedPage();
           // Application.Current.MainPage = new SharedTransitionNavigationPage(new HomeTabbedPage());
        }
    }
}