using AppBancaMutual.Models;
using AppBancaMutual.Service;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;

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


            //this.Email = "User";
            //this.Password = "123";
            navigationService = new NavigationService();

        }

        #endregion


        #region Commands
        //#######################################
        public ICommand LoginCommand => new RelayCommand(LoginCommands);
        public ICommand RegisterCommand => new RelayCommand(RegisterCommands);
        public ICommand RegisterWhatsAppCommand => new RelayCommand(RegisterWhatsAppCommands);

        public ICommand UrlCommand => new RelayCommand(UrlCommands);

        
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

            RequestUsuario obj = new RequestUsuario();
            obj.documentoIdentidad = email;
            obj.password = password;

            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://appservbm.azurewebsites.net");
            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var response = await cliente.PostAsync("api/Cliente", content);

            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
               var rt = JsonConvert.DeserializeObject<ResponseUsuario>(json_respuesta);
                if (rt.apellido != null)
                {
                    //await Application.Current.MainPage.DisplayAlert(
                    // "Alert",
                    // "El registro fue Exitoso Se comunicara con asesor de Banca Mutual !",
                    // "Accept");

                    MainViewModel.GetInstance().Registro = new RegistroViewModel();
                    navigationService.SetMainPage("MasterPage");

                    //string CodigoPaisCelular;
                    //CodigoPaisCelular = "+573207550469";
                    //Chat.Open(CodigoPaisCelular);

           
                }
                else
                {
                    MainViewModel.GetInstance().Login = new LoginViewModel();
                    navigationService.NavigateOnLogin("LoginPage");

                    await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Usuario No registrado comuniquese con un asesro",
                   "Accept");
                    return;

                }
            }
            else
            {
                MainViewModel.GetInstance().Login = new LoginViewModel();
                navigationService.NavigateOnLogin("LoginPage");

                await Application.Current.MainPage.DisplayAlert(
                   "Error",
                   "Esta Caido El sistema",
                   "Accept");
                return;

            }

          



        }
        //######################################

        private async void RegisterCommands()
        {
            //var answer = await Application.Current.MainPage.DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            //Debug.WriteLine("Answer: " + (answer ? "Yes" : "No"));



            //await Application.Current.MainPage.DisplayAlert(
            //        "Error",
            //        "Ingresar el usuario",
            //        "Accept");

            //para Tener en cuenta para Instaciamiento formularios
            MainViewModel.GetInstance().registroPersonaViewModel = new RegistroPersonaViewModel();
            await navigationService.NavigateOnLogin("RegistroPersonaPage");

        }

        private  void RegisterWhatsAppCommands()
        {
       
    

            string CodigoPaisCelular;
            CodigoPaisCelular = "+573207550469";
            Chat.Open(CodigoPaisCelular);

        }

        private async void UrlCommands()
        {
            //var answer = await Application.Current.MainPage.DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            //Debug.WriteLine("Answer: " + (answer ? "Yes" : "No"));
            var url =   "https://docs.google.com/forms/d/1c24lEK6a8YPK21kIHNUIHc1dnZ8cps2zvcWEgPt8uXw/viewform?edit_requested=true";
            Device.OpenUri(new Uri(url));
            


            //await Application.Current.MainPage.DisplayAlert(
            //        "Error",
            //        "Ingresar el usuario",
            //        "Accept");

            //para Tener en cuenta para Instaciamiento formularios

        }

 
        #endregion




    }

}
