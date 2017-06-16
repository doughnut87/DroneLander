using DroneLanderNew.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Slider), typeof(ThrottleControlRenderer))]
namespace DroneLanderNew.iOS.Renderers
{
    public class ThrottleControlRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetThumbImage(UIImage.FromFile("throttle_thumb.png"), UIControlState.Normal);
                Control.TintColor = UIColor.FromRGB(217, 0, 0);
            }
        }
    }
}