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
using MobilePhoneLibrary.Services;

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
            simCorpMobile.MessageStorage.SMSShow += ShowMessages;
            simCorpMobile.MessageStorage.SMSNotify += NotifyMessage;
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

        private void applyUsbBtn_Click(object sender, EventArgs e) {
            mobileOutBox.Clear();
            RadioButton checkedButton = usbAccessGrp.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null) { formInOut.SelectedVariant = checkedButton.Tag.ToString(); }
            simCorpMobile.SetUsbAccessory();
        }

        private void smsTimer_Tick(object sender, EventArgs e) {
            simCorpMobile?.ReceiveMessage();
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void NotifyMessage(string notification) {
            notificationBox.Text = notification;
        }

        private void SetMessageSettings() {
            simCorpMobile?.MessageStorage.SetViewSettings(new MessagesSettings(formatComboBox.SelectedIndex,
                contactComboBox.SelectedItem,
                searchMessageBox.Text,
                fromDateTimePick.Checked,
                fromDateTimePick.Value,
                toDateTimePick.Checked,
                toDateTimePick.Value,
                filterGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Equals(andFilterRBtn) ?? false ));
        }

        private void ShowMessages(List<PhoneMessage> messages) {
            if (messages.Count != 0) {
                UpdateContacts(messages);

                smsListView.Items.Clear();
                foreach (PhoneMessage message in messages) {
                    smsListView.Items.Add(new ListViewItem(new[] {
                    message.UserContact.GetContact(), message.FormatText}));
                }
            }
        }

        private void UpdateContacts(List<PhoneMessage> messages) {
            List<string> contacts = messages.Select(m => m.UserContact.GetContact()).Distinct().ToList();

            if (contactComboBox.Items.Count != 0) {
                contacts = contacts.Except(contactComboBox.Items.Cast<string>()).ToList();
            }

            if (contacts.Count != 0) {
                contactComboBox.Items.AddRange(contacts.ToArray());
            }
        }

        private void contactComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void contactComboBox_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(contactComboBox.Text))
            {
                SetMessageSettings();
                contactComboBox.Text = "Select Contact";
            }
        }

        private void searchMessageBox_TextChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void fromDateTimePick_ValueChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void toDateTimePick_ValueChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void andFilterRBtn_CheckedChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void orFilterRBtn_CheckedChanged(object sender, EventArgs e) {
            SetMessageSettings();
        }

        private void startMsgBtn_Click(object sender, EventArgs e) {
            smsTimer.Enabled = true;
        }

        private void stopMsgBtn_Click(object sender, EventArgs e) {
            smsTimer.Enabled = false;
        }
    }
}
