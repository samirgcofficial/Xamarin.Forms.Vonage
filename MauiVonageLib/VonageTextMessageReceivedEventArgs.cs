using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiVonageLib
{
    public sealed class VonageTextMessageReceivedEventArgs : EventArgs
    {
        public VonageTextMessageReceivedEventArgs(string message, string messageType)
        {
            Message = message;
            MessageType = messageType;
        }

        public string Message { get; }

        public string MessageType { get; }
    }
}
