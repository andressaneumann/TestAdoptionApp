using System;
using Android.Graphics.Drawables;
using TestAdoptionApp.Droid.Renderers;
using TestAdoptionApp.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//namespace 
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryBorder))]
namespace TestAdoptionApp.Droid.Renderers
{
    public class CustomEntryBorder : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (this.Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetShape(ShapeType.Rectangle);
                gd.SetCornerRadius(5);
                gd.SetStroke(3, Android.Graphics.Color.ParseColor("#707070"));
                this.Control.SetBackgroundDrawable(gd);
                //this.Control.SetHeight(90);
                this.Control.TextAlignment = Android.Views.TextAlignment.TextStart;
                this.Control.SetPadding(22, 28, 0, 0);
            }

        }
    }

}