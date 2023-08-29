using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AppBancaMutual.Droid.Renderers;
using AppBancaMutual.Renderers;

[assembly:ExportRenderer(typeof(BorderlessPicker),typeof(BorderlessPickerAndroid))]
namespace AppBancaMutual.Droid.Renderers
{
    public class BorderlessPickerAndroid : PickerRenderer
    {
        public BorderlessPickerAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}