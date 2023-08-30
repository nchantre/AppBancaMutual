using AppBancaMutual.Service;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppBancaMutual.ViewModels
{
    public class ActualizarInformacionClienteViewModel :BaseViewModel
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
        public ActualizarInformacionClienteViewModel()
        {
            this.IsRemembered = true;



            navigationService = new NavigationService();

        }

        #endregion


      
    }
}
