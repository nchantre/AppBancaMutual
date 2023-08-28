using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppBancaMutual.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private bool open;

        public ProfilePage()
        {
            InitializeComponent();
        }

        private void OrderInfoClick(object sender, EventArgs e)
        {
            if (!(sender is StackLayout stack)) return;
            switch (stack.ClassId)
            {
                case "MyOder":
                   // OpenPage(new MyOrderPage());
                    break;

                case "MyFav":
                   // OpenPage(new MyFavoritePage());
                    break;

                case "LastView":
                   // OpenPage(new LastViewPage());
                    break;

                case "MyComments":
                   // OpenPage(new MyCommentsPage());
                    break;
            }
        }

        private void OpenPage(Page page)
        {
            Navigation.PushAsync(page);
        }

        private void ChancePassClick(object sender, EventArgs e)
        {
           // Navigation.PushModalAsync(new ChangePasswordPage(), true);
        }

        private void ContactClick(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:Ufukzimmerman@gmail.com"));
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SharedTransitionNavigationPage(new MainPage());
        }

        private async void SettingClick(object sender, EventArgs e)
        {
            //open = open == false;
           
            //SettingsView.IsVisible = open;
        }
    }
}