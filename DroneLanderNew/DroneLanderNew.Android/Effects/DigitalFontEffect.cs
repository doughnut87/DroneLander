using System;
using System.ComponentModel;
using Android.Graphics;
using Android.Widget;
using DroneLanderNew.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(DigitalFontEffect), "FontEffect")]
namespace DroneLanderNew.Droid.Effects
{
    public class DigitalFontEffect : PlatformEffect
    {
        TextView control;
        protected override void OnAttached()
        {
            try
            {
                control = Control as TextView;
                var name = DroneLanderNew.Effects.DigitalFontEffect.GetFontFileName(Element);
                var path = "Fonts/" + name + ".ttf";
                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, path);
                control.Typeface = font;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == DroneLanderNew.Effects.DigitalFontEffect.FontFileNameProperty.PropertyName)
            {
                Typeface font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets, "Fonts/" + DroneLanderNew.Effects.DigitalFontEffect.GetFontFileName(Element) + ".ttf");
                control.Typeface = font;
            }
        }
    }
}