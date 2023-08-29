﻿using AppBancaMutual.Service;
using GalaSoft.MvvmLight.Command;
using System;
using System.Diagnostics;
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


            this.Email = "User";
            this.Password = "123";
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

        private async void RegisterWhatsAppCommands()
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

            string CodigoPaisCelular;
            CodigoPaisCelular = "+573207550469";
            Chat.Open(CodigoPaisCelular);

        }

        private async void UrlCommands()
        {
            //var answer = await Application.Current.MainPage.DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            //Debug.WriteLine("Answer: " + (answer ? "Yes" : "No"));
            var url =  "https://docs.google.com/forms/d/1c24lEK6a8YPK21kIHNUIHc1dnZ8cps2zvcWEgPt8uXw/viewform?edit_requested=true";
            Device.OpenUri(new Uri(url));
            


            //await Application.Current.MainPage.DisplayAlert(
            //        "Error",
            //        "Ingresar el usuario",
            //        "Accept");

            //para Tener en cuenta para Instaciamiento formularios

        }

        //private async void ShowCustomDialogButton_Clicked(object sender, EventArgs e)
        //{
        //    var customDialog = new CustomDialogPage();
        //    await Navigation.PushModalAsync(customDialog);
        //}

        #endregion




    }
    //public class CustomDialogPage : ContentPage
    //{
    //    public CustomDialogPage()
    //    {
    //        var messageLabel = new Label
    //        {
    //            Text = "Este es un cuadro de diálogo personalizado.",
    //            HorizontalOptions = LayoutOptions.CenterAndExpand,
    //            VerticalOptions = LayoutOptions.CenterAndExpand
    //        };

    //        var closeButton = new Button
    //        {
    //            Text = "Cerrar",
    //            BackgroundColor = Color.Blue, // Cambiar el color de fondo del botón
    //            TextColor = Color.White // Cambiar el color del texto del botón
    //        };

    //        closeButton.Clicked += async (sender, args) =>
    //        {
    //            await Navigation.PopModalAsync();
    //        };

    //        Content = new StackLayout
    //        {
    //            Children = { messageLabel, closeButton },
    //            Padding = new Thickness(20)
    //        };
    //    }
    //}
}