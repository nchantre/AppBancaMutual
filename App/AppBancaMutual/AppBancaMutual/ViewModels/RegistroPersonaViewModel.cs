using AppBancaMutual.Models;
using AppBancaMutual.Renderers;
using AppBancaMutual.Service;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppBancaMutual.ViewModels
{
    public class RegistroPersonaViewModel : BaseViewModel
    {

        #region Services
        public NavigationService navigationService;
        #endregion

        #region Attributes
    
        private bool isRunning;
        private bool isEnabled;


        private int tipoDocumentoId;
        private string documento;
        private string nombres;
        private string apellidos;
        private string email;
        private string phone;
        private DateTime fechaRegistro;
        #endregion

        #region Properties
        public int TipoDocumentoId
        {
            get { return this.tipoDocumentoId; }
            set { SetValue(ref this.tipoDocumentoId, value); }

        }
        public string Documento
        {
            get { return this.documento; }
            set { SetValue(ref this.documento, value); }

        }

        public string Nombres
        {
            get { return this.nombres; }
            set { SetValue(ref this.nombres, value); }

        }
        public string Apellidos
        {
            get { return this.apellidos; }
            set { SetValue(ref this.apellidos, value); }

        }

        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }

        }

        public string Phone
        {
            get { return this.phone; }
            set { SetValue(ref this.phone, value); }

        }
        public DateTime FechaRegistro
        {
            get { return this.fechaRegistro; }
            set { SetValue(ref this.fechaRegistro, value); }

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
        public RegistroPersonaViewModel()
        {
            this.IsRemembered = true;


 
            navigationService = new NavigationService();

        }

        #endregion


        #region Commands
        //#######################################
        public ICommand RegistroPersonaCommand => new RelayCommand(RegistroPersonaCommands);
        public ICommand CancelarCommand => new RelayCommand(CancelarCommands);
        //#######################################
        #endregion

        #region Methodos

        private async void RegistroPersonaCommands()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar el usuario",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingresar la contraseña",
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            DateTime thisDay = DateTime.Today;
            RequestRegistroUsario obj = new RequestRegistroUsario();
            obj.tipoDocumentoId = "1";
            obj.documentoIdentidad = Documento;
            obj.nombre = Nombres;
            obj.apellido = Apellidos;
            obj.correo = Email;
            obj.celular = Phone;
            obj.fechaRegistro = thisDay;


            bool respuesta = false;

            var cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://appservbm.azurewebsites.net");
            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            var response = await cliente.PutAsync("api/Cliente", content);

            if (response.IsSuccessStatusCode)
            {
                var json_respuesta = await response.Content.ReadAsStringAsync();
    
     
                    await Application.Current.MainPage.DisplayAlert(
                   "Alert",
                   "El registro fue Exitoso !",
                   "Accept");
                MainViewModel.GetInstance().Login = new LoginViewModel();
                navigationService.NavigateOnLogin("LoginPage");
                return;

        
            }
            else
            {
                MainViewModel.GetInstance().Login = new LoginViewModel();
                navigationService.NavigateOnLogin("LoginPage");

                await Application.Current.MainPage.DisplayAlert(
                   "Alert",
                   "Usuario no registrado",
                   "Accept");
                return;

            }


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
          //  navigationService.SetMainPage("MasterPage");



        }
        //######################################

        private async void CancelarCommands()
        {
            //para Tener en cuenta para Instaciamiento formularios
            MainViewModel.GetInstance().Login = new LoginViewModel();
            await navigationService.NavigateOnLogin("LoginPage");

        }

        #endregion

    }
}
