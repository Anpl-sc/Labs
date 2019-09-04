using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneLibrary;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            ConsoleInOut consoleInOut = new ConsoleInOut();
            Mobile simCorpMobile = new SimCorpMobile(consoleInOut);
            Console.Write(simCorpMobile);
            simCorpMobile.SetAudioAccessory();
            simCorpMobile.SetUsbAccessory();
            Console.ReadKey();
        }
    }
}
