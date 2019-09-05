using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Services {
    public class SMS {
        public delegate void SMSRecievedDelegate(string message);

        public event SMSRecievedDelegate SMSReceived;

    }
}
