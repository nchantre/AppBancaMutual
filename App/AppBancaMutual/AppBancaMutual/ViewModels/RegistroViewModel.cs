
using AppBancaMutual.Service;
using AppBancaMutual.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppBancaMutual.ViewModels
{
    public class RegistroViewModel : BaseViewModel
    {
        #region Services
        public NavigationService navigationService;
        #endregion

        #region Attributes
        private string ubicacion_Categoria;
        private string codigo;
        private string cantidad; 
        private bool isEnabled;
        #endregion


        #region Properties
        public string Ubicacion_Categoria
        {
            get { return this.ubicacion_Categoria; }
            set { SetValue(ref this.ubicacion_Categoria, value); }

        }
        public string Codigo
        {
            get { return this.codigo; }
            set { SetValue(ref this.codigo, value); }

        }
        public bool IsRemembered { get; set; }

        public string Cantidad
        {
            get { return this.cantidad; }
            set { SetValue(ref this.cantidad, value); }

        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        #endregion


        #region Constructor
        public RegistroViewModel()
        {
            this.IsRemembered = true;

            navigationService = new NavigationService();
        }
        #endregion


      

        #region Commands
        //#######################################
        public ICommand RegistroCommand => new RelayCommand(RegistroCommands);
        public ICommand EscanerCommand => new RelayCommand(EscanerCommands);

        public ICommand PrestamoCommand => new RelayCommand(PrestamoCommands);

        public ICommand EstadoPrestamoCommand => new RelayCommand(EstadoPrestamoCommands);


        public ICommand PagoCommand => new RelayCommand(PagoCommans);
        

        //#######################################
        #endregion

        #region Methodos
        private async void RegistroCommands()
        {

            //IFolder rootFolder = FileSystem.Current.LocalStorage;
            //string filename = Configuraciones.PathApp + "/HolaMundo.pdf";
            ////filename queda como: /data/user/0/GenerarPDF.android/files/HolaMundo.pdf

            //byte[] byteArray = Encoding.UTF8.GetBytes(filename);
            //MemoryStream stream = new MemoryStream(byteArray);

            //Document doc = new Document(PageSize.A4);
            //PdfWriter escritor = PdfWriter.GetInstance(doc, stream);
            //doc.AddTitle("Mi primer PDF");
            //doc.Open();
            string mensaje = "Tecnologia,568989555,89";
            //DependencyService.Get<IFileservice>().CreateFile(mensaje);
            //string nombre = "uno.txt";
            //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            // var uno = Application.Context.GetExternalFilesDir(null).AbsolutePath;

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            // string td = Environment.GetExternalStoragePublicDirectory(Environment.DirectoryDocuments).AbsolutePath;

            //var dato = "/storage/emulated/0/Documents/";

            //List<string> arquivos = new List<string>();
            //DirectoryInfo d = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //FileInfo[] Files = d.GetFiles();


            //string RutaCompleta = Path.Combine(ruta, nombre);
            //using (var escrito = File.CreateText(RutaCompleta))
            //{
            //    await escrito.WriteAsync("hola mundo");

            //}


            //bool isWriteable = Environment.MediaMounted.Equals(Environment.ExternalStorageState);

            await Application.Current.MainPage.DisplayAlert(
                           "",
                           "Registro Exitoso",
                           "Aceptar");


        }



        private async void PrestamoCommands()
        {

            MainViewModel.GetInstance().solicitarPrestamoViewModel = new SolicitarPrestamoViewModel();
            await navigationService.NavigateOnMaster("SolicitarPrestamoPage");


     


        }

        private async void EstadoPrestamoCommands()
        {

            MainViewModel.GetInstance().estadoPrestamoViewModel = new EstadoPrestamoViewModel();
            await navigationService.NavigateOnMaster("EstadoPrestamoPage");

        }


        private async void PagoCommans()
        {

            MainViewModel.GetInstance().pagoViewModel = new PagoViewModel();
            await navigationService.NavigateOnMaster("PagosPage");

        }

        private async void EscanerCommands()
        {
            //string nombre = "uno.txt";
            //string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //string RutaCompleta = Path.Combine(ruta, nombre);

            //if (File.Exists(RutaCompleta))
            //{
            //    using (var lector = new StreamReader(RutaCompleta, true)) 
            //    {
            //        string txt;
            //        while((txt= await lector.ReadLineAsync())!= null)
            //        {
            //            string hola = txt;
            //        }
            //    }
            //}


            await Application.Current.MainPage.DisplayAlert(
                       "Error",
                       "Registro Exitoso",
                       "Aceptar");

        


        }

        #endregion

        #region CodigoBarras

        private string _result;
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand ButtonCommand { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnButtomCommand()
        {
            //var options = new MobileBarcodeScanningOptions();
            //options.PossibleFormats = new List<BarcodeFormat>
            //{
            //    BarcodeFormat.QR_CODE,
            //    BarcodeFormat.CODE_128,
            //    BarcodeFormat.EAN_13
            //};
            //var page = new ZXingScannerPage(options) { Title = "Scanner" };
            //var closeItem = new ToolbarItem { Text = "Close" };
            //closeItem.Clicked += (object sender, EventArgs e) =>
            //{
            //    page.IsScanning = false;
            //    Device.BeginInvokeOnMainThread(() =>
            //    {
            //        Application.Current.MainPage.Navigation.PopModalAsync();
            //    });
            //};
            //page.ToolbarItems.Add(closeItem);
            //page.OnScanResult += (result) =>
            //{
            //    page.IsScanning = false;

            //    Device.BeginInvokeOnMainThread(() => {
            //        Application.Current.MainPage.Navigation.PopModalAsync();
            //        if (string.IsNullOrEmpty(result.Text))
            //        {
            //            Result = "No valid code has been scanned";
            //        }
            //        else
            //        {
            //            Application.Current.MainPage.DisplayAlert(
            //             "Error",
            //             "Registro Exitoso",
            //             "Aceptar");
            //            Result = $"Result: {result.Text}";
            //        }
            //    });
            //};
            //Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(page) { BarTextColor = Color.Blue, BarBackgroundColor = Color.Black }, true);
        }

        #endregion




    }
}
