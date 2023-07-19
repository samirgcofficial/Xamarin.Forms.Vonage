using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiVonageLib
{
    public sealed class VonageErrorOccurredEventArgs : EventArgs
    {
        public VonageErrorOccurredEventArgs(string message)
            => Message = message;

        public string Message { get; }
    }
}
