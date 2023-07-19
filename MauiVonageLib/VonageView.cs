using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiVonageLib
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class VonageView : View
    {
        public static BindableProperty IsVideoViewRunningProperty = BindableProperty.Create(nameof(IsVideoViewRunning), typeof(bool), typeof(VonageView), false, BindingMode.OneWayToSource);

        public bool IsVideoViewRunning
        {
            get => (bool)GetValue(IsVideoViewRunningProperty);
            set => SetValue(IsVideoViewRunningProperty, value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetIsVideoViewRunning(bool value) => IsVideoViewRunning = value;
    }

}
