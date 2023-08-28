

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBancaMutual.ModalPages;

using AppBancaMutual.Models;

namespace AppBancaMutual.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasketPage
    {
        public BasketPage()
        {
            InitializeComponent();
           // BasketItems.ItemsSource = ProductList;
        }

        private void Button_OnPressed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddAddressClick(object sender, EventArgs e)
        {
           // Navigation.PushModalAsync(new AddNewAddressPage());
        }

        private void ContinueClick(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new SelectCreditCardPage(), true);
        }
    }
}