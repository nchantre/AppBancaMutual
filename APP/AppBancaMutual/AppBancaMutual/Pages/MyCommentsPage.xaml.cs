using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBancaMutual.Models;

namespace AppBancaMutual.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyCommentsPage : ContentPage
	{
        private readonly List<StartList> _startList = new List<StartList>();
        public MyCommentsPage ()
		{
            _startList.Add(new StartList
            {
                StarImg = "fillstar.png"
            });
            _startList.Add(new StartList
            {
                StarImg = "fillstar.png"
            });
            _startList.Add(new StartList
            {
                StarImg = "fillstar.png"
            });
            _startList.Add(new StartList
            {
                StarImg = "fillstar.png"
            });
            _startList.Add(new StartList
            {
                StarImg = "emptystar.png"
            });
            InitializeComponent ();
           // starListComment.ItemsSource = _startList;
           // starListComment2.ItemsSource = _startList;

        }

      
    }
}