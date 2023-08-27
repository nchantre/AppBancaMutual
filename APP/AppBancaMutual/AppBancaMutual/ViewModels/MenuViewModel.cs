﻿using AppBancaMutual.Service;
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
                case "RecomendacionPage":
                   // MainViewModel.GetInstance().Recomendacion = new RecomendacionViewModel();
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
