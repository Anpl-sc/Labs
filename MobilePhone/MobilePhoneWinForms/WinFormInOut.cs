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

        public int ReadChoice(string choiceName, string[] choiceVariants)
        {
            WriteLine(choiceName);
            if (SelectedVariant != null)
            {
                for (int i = 0; i < choiceVariants.Length; i++) {
                    if (choiceVariants[i] == SelectedVariant) { return i + 1; }
                }
            }
            return 0;
        }
    }
}
