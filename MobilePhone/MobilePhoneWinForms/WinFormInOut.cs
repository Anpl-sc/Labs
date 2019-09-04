using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneLibrary;

namespace MobilePhoneWinForms {
    class WinFormInOut : IUserInOut
    {
        private TextBox mobileOutBox;
        public string SelectedVariant { get; set; }

        public WinFormInOut(TextBox mobileOutBox) {
            this.mobileOutBox = mobileOutBox;
        }

        public void Write(string text) {
            mobileOutBox.AppendText(text);
        }

        public void WriteLine(string text) {
            Write(text);
            mobileOutBox.AppendText("\r\n");
        }

        public int ReadChoise(string choiseName, string[] choiseVariants)
        {
            WriteLine(choiseName);
            if (SelectedVariant != null)
            {
                for (int i = 0; i < choiseVariants.Length; i++) {
                    if (choiseVariants[i] == SelectedVariant) { return i + 1; }
                }
            }
            return 0;
        }
    }
}
