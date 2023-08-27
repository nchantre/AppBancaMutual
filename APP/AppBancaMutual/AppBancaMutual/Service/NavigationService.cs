using AppBancaMutual.Views;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace AppBancaMutual.Service
{
    public class NavigationService
    {
        public void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "LoginPage":
                    Application.Current.MainPage = new NavigationPage(new LoginPage());
                    break;
                case "MasterPage":
                    Application.Current.MainPage = new MasterPage();
                    break;

            }
        }

        public async Task NavigateOnMaster(string pageName)
        {
            //App.Master.IsPresented = false;

            //switch (pageName)
            //{
            //    case "FrmunoPage":
            //        await App.Navigator.PushAsync(
            //            new FrmunoPage());
            //        break;
            //    case "FrmdosPage":
            //        await App.Navigator.PushAsync(
            //            new FrmdosPage());
            //        break;
            //    case "RecomendacionPage":
            //        await App.Navigator.PushAsync(
            //            new RecomendacionPage());
            //        break;

            //}
        }

        public async Task NavigateOnLogin(string pageName)
        {
            switch (pageName)
            {
                case "PersonafrmPage":
                //await Application.Current.MainPage.Navigation.PushAsync(
                //    new PersonafrmPage());
                //break;
                case "LoginFacebookView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new LoginPage());
                    break;
                case "PasswordRecoveryView":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new LoginPage());
                    break;
            }
        }

        public async Task BackOnMaster()
        {
            await App.Navigator.PopAsync();
        }

        public async Task BackOnLogin()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
