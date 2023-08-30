using AppBancaMutual.Service;
using AppBancaMutual.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppBancaMutual.ViewModels
{
    public class MenuViewModel : BaseMenuItem
    {
        #region Services
        // DataService dataService;
        public NavigationService navigationService;
        #endregion

        #region Constructor
        public MenuViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion

        #region Properties

        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        #endregion

        #region Commands
        public ICommand NavigateCommand => new RelayCommand(Navigate);

        public async void Navigate()
        {

            switch (PageName)
            {
                case "LoginPage":
                    MainViewModel.GetInstance().Login = new LoginViewModel();
                     var mainViewModel = MainViewModel.GetInstance();
                     mainViewModel.Login = new LoginViewModel();
                    navigationService.SetMainPage(PageName);
                    break;
                case "ActualizarInformacionClientePage":
                    MainViewModel.GetInstance().actualizarInformacionClienteViewModel = new ActualizarInformacionClienteViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;
                case "ProductosAdquiridosPage":
                    MainViewModel.GetInstance().productosAdquiridosViewModel = new ProductosAdquiridosViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;
                case "RegistroPage":
                    MainViewModel.GetInstance().Registro = new RegistroViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;
                case "SolicitarPrestamoPage":
                    MainViewModel.GetInstance().solicitarPrestamoViewModel = new SolicitarPrestamoViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;


                case "AlarmaPage":
                    //MainViewModel.GetInstance().Sync = new SyncViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;
                case "MyProfileView":
                    //MainViewModel.GetInstance().MyProfile =
                    //    new MyProfileViewModel();
                    await navigationService.NavigateOnMaster(PageName);
                    break;
            }
        }


        public ICommand LoginCommand => new RelayCommand(LoginCommands);

        private void LoginCommands()
        {
            throw new NotImplementedException();
        }
        #endregion
    }


}
