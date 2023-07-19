using Android.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiVonageLib
{
    public static class PlatformVonage
    {
        internal static Activity Activity { get; private set; }

        public static PlatformVonageService Current => CrossVonage.Current as PlatformVonageService;

        public static void Init(Activity activity)
        {
            Activity = activity;
            VonagePublisherViewRenderer.Preserve();
            VonageSubscriberViewRenderer.Preserve();
            CrossVonage.Init<PlatformVonageService>();
        }
    }
}
