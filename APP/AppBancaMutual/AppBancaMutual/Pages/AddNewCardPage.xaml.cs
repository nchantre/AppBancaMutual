using System;
using System.ComponentModel;
using Xamarin.Forms.Xaml;


namespace AppBancaMutual.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class AddNewCardPage
    {
        public AddNewCardPage()
        {
            InitializeComponent();
           // this.BindingContext = new CreditCardPageViewModel();
        }

        private void BackButton(object sender, EventArgs e)
        {
           // Navigation.PopModalAsync(true);
        }
    }
}