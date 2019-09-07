using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int messageCounter;

        public mobilePhoneWin() {
            InitializeComponent();
            InitializePhone();
        }

        private void InitializePhone() {
            formInOut = new WinFormInOut(mobileOutBox);
            simCorpMobile = new SimCorpMobile(formInOut);
            simCorpMobile.MessageService.SMSReceived += m => smsBox.AppendText(Environment.NewLine + m);
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

        private void smsTimer_Tick(object sender, EventArgs e) {
            messageCounter ++;
            string message = "Some Message #" + messageCounter;
            simCorpMobile.MessageService.ReceiveMessage(message);
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            simCorpMobile.MessageService.SetFormatting(formatComboBox.SelectedIndex);
        }
    }
}
