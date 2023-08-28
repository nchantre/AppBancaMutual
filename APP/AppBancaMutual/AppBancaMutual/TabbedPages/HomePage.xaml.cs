using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;



namespace AppBancaMutual.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();

            //PreviousViewedList1.ItemsSource = ProductLists;
            //PreviousViewedList.ItemsSource = ProductLists;
            //ListViewCategory.ItemsSource = CategoryList;
            //CarouselView.ItemsSource = CarouselList;
        }


        private async void ProductDetailClick(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new ProductDetail());
        }
        private async void ClickCategoryDetail(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new CategoryDetailPage());
        }
    }
}