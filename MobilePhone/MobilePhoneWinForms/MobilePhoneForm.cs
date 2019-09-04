using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneLibrary;

namespace MobilePhoneWinForms {
    public partial class mobilePhoneWin : Form {
        private SimCorpMobile simCorpMobile;
        private WinFormInOut formInOut;

        public mobilePhoneWin() {
            InitializeComponent();
            InitializePhone();
        }

        private void InitializePhone() {
            formInOut = new WinFormInOut(mobileOutBox);
            simCorpMobile = new SimCorpMobile(formInOut);
        }

        private void mobileInfoBtn_Click(object sender, EventArgs e) {
            mobileOutBox.Clear();
            mobileOutBox.AppendText(simCorpMobile.ToString());
        }

        private void applyAudioBtn_Click(object sender, EventArgs e) {
            mobileOutBox.Clear();
            RadioButton checkedButton = audioAccessGrp.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null) { formInOut.SelectedVariant = checkedButton.Tag.ToString(); }
            simCorpMobile.SetAudioAccessory();
        }

        private void ApplyUsbBtn_Click(object sender, EventArgs e) {
            mobileOutBox.Clear();
            RadioButton checkedButton = usbAccessGrp.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null) { formInOut.SelectedVariant = checkedButton.Tag.ToString(); }
            simCorpMobile.SetUsbAccessory();
        }
    }
}
