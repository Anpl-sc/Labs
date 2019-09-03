using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Device;

namespace MobilePhone {
    class Program {
        static void Main(string[] args) {
            Mobile simCorpMobile = new SimCorpMobile();
            Console.Write(simCorpMobile);
            simCorpMobile.SetAccessories();
            Console.ReadKey();
        }
    }
}
