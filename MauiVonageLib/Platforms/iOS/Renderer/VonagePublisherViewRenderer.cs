using Foundation;
using UIKit;

namespace MauiVonageLib
{
    [Preserve(AllMembers = true)]
    public class VonagePublisherViewRenderer : VonageViewRenderer
    {
        public static void Preserve() { }

        protected override UIView GetNativeView() => PlatformVonage.Current.PublisherKit?.View;

        protected override void SubscribeResetControl() => PlatformVonage.Current.PublisherUpdated += ResetControl;

        protected override void UnsubscribeResetControl() => PlatformVonage.Current.PublisherUpdated -= ResetControl;
    }
}