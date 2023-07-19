using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiVonageLib
{
    [EditorBrowsable(EditorBrowsableState.Always)]
    public sealed class VonageSubscriberView : VonageView
    {
        public static readonly BindableProperty StreamIdProperty = BindableProperty.Create(nameof(StreamId), typeof(string), typeof(VonageSubscriberView));

        public string StreamId
        {
            get => GetValue(StreamIdProperty) as string;
            set => SetValue(StreamIdProperty, value);
        }
    }
}
