using Android.Content;
using TravelApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessSearchBarRenderer), typeof(BorderlessSearchBarRenderer))]
namespace TravelApp.Droid.Renderers
{

    public class BorderlessSearchBarRenderer : SearchBarRenderer
    {
        public BorderlessSearchBarRenderer(Context context) : base(context)
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                int searchPlateId = Control.Context.Resources.GetIdentifier("android:id/search_plate", null, null);
                Android.Views.View searchPlateView = Control.FindViewById(searchPlateId);
                searchPlateView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}