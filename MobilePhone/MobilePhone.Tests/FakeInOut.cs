using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneLibrary;

namespace MobilePhone.Tests {
    public class FakeInOut : IUserInOut {
        public string FakeWrite { get; set; }
        public string[] InputVariants { get; private set; }
        public string InputChoise { get; private set; }
        public int Selected { get; set; } = 0;

        public void Write(string text) {
            FakeWrite = FakeWrite + text;
        }

        public void WriteLine(string text) {
            FakeWrite = FakeWrite + text;
        }

        public int ReadChoise(string choiseName, string[] choiseVariants) {
            InputChoise = choiseName;
            InputVariants = choiseVariants;
            return Selected;
        }
    }
}
