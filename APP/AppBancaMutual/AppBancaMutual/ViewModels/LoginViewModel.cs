using AppBancaMutual.Service;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;
namespace AppBancaMutual.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Services
        public NavigationService navigationService;
        #endregion

        #region Attributes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion


        #region Properties
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }

        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }

        }
        public bool IsRemembered { get; set; }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }

        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;


            this.Email = "User";
            this.Password = "123";
            navigationService = new NavigationService();

        }

        #endregion


        #region Commands
        //#######################################
        public ICommand LoginCommand => new RelayCommand(LoginCommands);
        public ICommand RegisterCommand => new RelayCommand(RegisterCommands);
        //#######################################
        #endregion

        #region Methodos

        private async void LoginCommands()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar el usuario",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar la contraseña",
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;

            //if (this.Email != "liana.pruebas@uniminuto.edu.co" || this.Password != "Colombia2019*")
            //{
            //    this.IsRunning = false;
            //    this.IsEnabled = true;

            //    await Application.Current.MainPage.DisplayAlert(
            //        "Error",
            //        "Email or Password incorrect",
            //        "Accept");

            //    this.Password = string.Empty;
            //    this.Email = string.Empty;
            //    return;
            //}

            //this.IsRunning = false;
            //this.IsEnabled = true;

            //this.Password = string.Empty;
            //this.Email = string.Empty;

            //WSClientViewModel client = new WSClientViewModel();
            //byte[] byt = System.Text.Encoding.UTF8.GetBytes(this.Password);
            //string passwd = Convert.ToBase64String(byt);
            //var result = await client.Get<Dominio>("https://zonaestudiantes.uniminuto.edu/ServiciosAPI/API/LDAP/AutenticarUsuario/" + this.Email + "/" + passwd + "/ACTIVOS");

            ////Que string URLComplemento = "API/LDAP/AutenticarUsuario/" + pCorreo + "/" + passwd + "/" + pTipousuario;
            //if (result != null)
            //{
            //    // DocumentoHabeasData = result.DocumentoHabeasData;
            //}

          //  MainViewModel.GetInstance().Habeasdata = new HabeasdataViewModel();
           // MainViewModel.GetInstance().Registro = new RegistroViewModel();
            navigationService.SetMainPage("MasterPage");



        }
        //######################################

        private async void RegisterCommands()
        {


            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar el usuario",
                    "Accept");
                return;
            }
            //para Tener en cuenta para Instaciamiento formularios
            MainViewModel.GetInstance().registroPersonaViewModel = new RegistroPersonaViewModel();
            await navigationService.NavigateOnLogin("RegistroPersonaPage");

        }

        #endregion




    }
}
