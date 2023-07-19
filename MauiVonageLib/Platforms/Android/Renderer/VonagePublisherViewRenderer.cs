﻿using Android.Content;
using AView = Android.Views.View;
using Android.Runtime;
using SystemIntPtr = System.IntPtr;
using AndroidRuntimeJniHandleOwnership = Android.Runtime.JniHandleOwnership;

namespace MauiVonageLib
{
    [Preserve(AllMembers = true)]
    public class VonagePublisherViewRenderer : VonageViewRenderer
    {
        public VonagePublisherViewRenderer(Context context) : base(context)
        {
        }

#pragma warning disable
        public VonagePublisherViewRenderer(SystemIntPtr p0, AndroidRuntimeJniHandleOwnership p1) : this(PlatformVonage.Activity)
        {
        }
#pragma warning restore

        public static void Preserve() { }

        protected override AView GetNativeView() => PlatformVonage.Current.PublisherKit?.View;

        protected override void SubscribeResetControl() => PlatformVonage.Current.PublisherUpdated += ResetControl;

        protected override void UnsubscribeResetControl() => PlatformVonage.Current.PublisherUpdated -= ResetControl;
    }
}
