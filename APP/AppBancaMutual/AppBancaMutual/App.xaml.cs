using AppBancaMutual.Service;
using AppBancaMutual.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancaMutual
{
    public partial class App : Application
    {
        #region Services
        // private ApiService apiService;
        //DataService dataService;
        //DialogService dialogService;
        NavigationService navigationService;
        #endregion
        public App()
        {
            InitializeComponent();

            //FlowListView.Init();

            //MainPage = new SharedTransitionNavigationPage(new MainPage());
            navigationService = new NavigationService();
            navigationService.SetMainPage("LoginPage");
        }

        #region Properties
        public static NavigationPage Navigator
        {
            get;
            internal set;
        }

        public static MasterPage Master
        {
            get;
            internal set;
        }
        #endregion

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
