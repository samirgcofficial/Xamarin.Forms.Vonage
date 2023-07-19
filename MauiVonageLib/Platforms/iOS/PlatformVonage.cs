using UIKit;

namespace MauiVonageLib
{
    public static class PlatformVonage
    {
        public static PlatformVonageService Current => CrossVonage.Current as PlatformVonageService;

        public static void Init(UIApplicationDelegate _)
        {
            VonagePublisherViewRenderer.Preserve();
            VonageSubscriberViewRenderer.Preserve();
            CrossVonage.Init<PlatformVonageService>();
        }
    }
}
