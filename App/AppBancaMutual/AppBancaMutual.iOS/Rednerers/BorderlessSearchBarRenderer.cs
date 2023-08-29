using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using AppBancaMutual.iOS.Rednerers;
using AppBancaMutual.Renderers;

[assembly: ExportRenderer(typeof(BorderlessSearchBar), typeof(BorderlessSearchBarRenderer))]
namespace AppBancaMutual.iOS.Rednerers
{
    public class BorderlessSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control==null)return;
            Control.Layer.BorderWidth = 0;
            
        }
    }
}