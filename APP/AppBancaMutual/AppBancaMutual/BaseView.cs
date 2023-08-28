using AppBancaMutual.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AppBancaMutual
{
    public class BaseView : ContentPage
    {
        public List<Category> CategoryList = new List<Category>();
        public List<Category> CarouselList = new List<Category>();
        public ObservableCollection<ProductListModel> ProductLists = new ObservableCollection<ProductListModel>();

        public BaseView()
        {
            CategoryList.Add(new Category
            {
                CategoryName = "Brushs",
                Image = "barberBrush.png"
            }); CategoryList.Add(new Category
            {
                CategoryName = "Scissors",
                Image = "barberScissors.png"
            }); CategoryList.Add(new Category
            {
                CategoryName = "Seats",
                Image = "barberSeat.png"
            }); CategoryList.Add(new Category
            {
                CategoryName = "Sets",
                Image = "barberShops.png"
            }); CategoryList.Add(new Category
            {
                CategoryName = "Dryers",
                Image = "hairDryer.png"
            }); CategoryList.Add(new Category
            {
                CategoryName = "Razors",
                Image = "shoeBrush.png"
            });
            CarouselList.Add(new Category
            {
                CategoryName = "im1",
                Image = "im1.jpg"
            });
            CarouselList.Add(new Category
            {
                CategoryName = "im2",
                Image = "shoeBrush.jpg"
            });
            CarouselList.Add(new Category
            {
                CategoryName = "im3",
                Image = "im3.jpg"
            });
            CarouselList.Add(new Category
            {
                CategoryName = "im4",
                Image = "im4.png"
            });

            ProductLists.Add(new ProductListModel
            {
                Title = "Scissor",
                Brand = "Cellur",
                Image = "scissors",
                Price = 15,

            });
            ProductLists.Add(new ProductListModel
            {
                Title = "Shaver",
                Brand = "Braun",
                Image = "machine",
                Price = 150,

            });
            ProductLists.Add(new ProductListModel
            {
                Title = "Scissor",
                Brand = "Cellur",
                Image = "scissors",
                Price = 15,

            });
            ProductLists.Add(new ProductListModel
            {
                Title = "Shaver",
                Brand = "Braun",
                Image = "machine",
                Price = 150,

            });
        }
    }
}
