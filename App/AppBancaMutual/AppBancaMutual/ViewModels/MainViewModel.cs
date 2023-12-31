﻿using AppBancaMutual.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppBancaMutual.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        //############################################
        public LoginViewModel Login { get; set; }

        public RegistroPersonaViewModel registroPersonaViewModel { get; set; }
        public ActualizarInformacionClienteViewModel actualizarInformacionClienteViewModel { get; set; }

        public ProductosAdquiridosViewModel productosAdquiridosViewModel { get; set; }

        public SolicitarPrestamoViewModel solicitarPrestamoViewModel { get; set; }

        public EstadoPrestamoViewModel estadoPrestamoViewModel { get; set; }

        public PagoViewModel pagoViewModel { get; set; }

        //public HabeasdataViewModel Habeasdata { get; set; }
        public RegistroViewModel Registro { get; set; }
        //public FrmunoViewModel Frmuno { get; set; }
        //public FrmdosViewModel Frmdos { get; set; }
        //public RecomendacionViewModel Recomendacion { get; set; }
        public MenuViewModel Menufrm { get; set; }
        public ObservableCollection<MenuViewModel> MyMenu { get; set; }
        //public PersonafrmViewModel Personafrm { get; set; }

        //############################################
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();

            }
            return instance;
        }

        #endregion

        #region Methods
        private void LoadMenu()
        {
            MyMenu = new ObservableCollection<MenuViewModel>();

            MyMenu.Add(new MenuViewModel
            {
                Icon = "ic_home",
                PageName = "RegistroPage",
                Title = "Inicio",
            });

            MyMenu.Add(new MenuViewModel
            {
                Icon = "ic_assignment",
                PageName = "ActualizarInformacionClientePage",
                Title = "Actualizacion Cliente",
            });
            MyMenu.Add(new MenuViewModel
            {
                Icon = "ic_assignment",
                PageName = "ProductosAdquiridosPage",
                Title = "Productos Adquiridos",
            });


            MyMenu.Add(new MenuViewModel
            {
                Icon = "ic_cancel",
                PageName = "LoginPage",
                Title = "Salir",
            });
        }

        #endregion

        //############################################


    }
}
