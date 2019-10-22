using System;
using CoreGraphics;
using DLLApp.iOS.Renderers;
using TestAdoptionApp.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryBorder))]
namespace DLLApp.iOS.Renderers
{
    public class CustomEntryBorder : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && Control != null)
            {
                var view = (Entry)Element;

                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = 5;
                Control.Layer.BorderWidth = 1f;
                Control.Layer.BorderColor = UIColor.FromRGB(112, 112, 112).CGColor;

                // Invisible views create padding at the beginning and end
                Control.LeftView = new UIView(new CGRect(0, 0, 8, Control.Frame.Height));
                Control.RightView = new UIView(new CGRect(0, 0, 8, Control.Frame.Height));
                Control.LeftViewMode = UITextFieldViewMode.Always;
                Control.RightViewMode = UITextFieldViewMode.Always;

                // Fixed height creates padding at top and bottom
                //Element.HeightRequest = 55;
            }
        }
    }
}
