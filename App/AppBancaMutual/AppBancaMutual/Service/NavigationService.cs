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
            App.Master.IsPresented = false;

            switch (pageName)
            {
                case "RegistroPage":
                    await App.Navigator.PushAsync(
                        new RegistroPage());
                    break;
                case "ActualizarInformacionClientePage":
                    await App.Navigator.PushAsync(
                        new ActualizarInformacionClientePage());
                    break;
                case "SolicitarPrestamoPage":
                    await App.Navigator.PushAsync(
                        new SolicitarPrestamoPage());
                    break;
                case "EstadoPrestamoPage":
                    await App.Navigator.PushAsync(
                        new EstadoPrestamoPage());
                    break;
                case "PagosPage":
                    await App.Navigator.PushAsync(
                        new PagosPage());
                    break;
                    

                case "ProductosAdquiridosPage":
                    await App.Navigator.PushAsync(
                        new ProductosAdquiridosPage());
                    break;

            }
        }

        public async Task NavigateOnLogin(string pageName)
        {
            switch (pageName)
            {
                
                case "RegistroPersonaPage":
                    await Application.Current.MainPage.Navigation.PushAsync(
                        new RegistroPersonaPage());
                    break;
                case "LoginPage":
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
