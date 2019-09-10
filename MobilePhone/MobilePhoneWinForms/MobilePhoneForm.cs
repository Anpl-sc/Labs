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
            //simCorpMobile.MessageStorage.SetFormatting(formatComboBox.SelectedIndex);
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
                //List<PhoneMessage> filteredMessages = ApplyFilters(messages);

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

        private List<PhoneMessage> ApplyFilters(List<PhoneMessage> messages)
        {
            List<PhoneMessage> contactFiltered = ContactFilter(messages);
            List<PhoneMessage> textFiltered = TextFilter(messages);
            List<PhoneMessage> dateFiltered = DateFilter(messages);

            RadioButton checkedButton = filterGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                if (checkedButton.Equals(andFilterRBtn))
                {
                    messages = contactFiltered.Intersect(textFiltered.Intersect(dateFiltered)).ToList();
                }
                else
                {
                    List<PhoneMessage> orMessages = new List<PhoneMessage>();
                    if (contactComboBox.SelectedItem != null)
                    {
                        orMessages = orMessages.Union(contactFiltered).ToList();
                        messages = orMessages;
                    }
                    if (!string.IsNullOrWhiteSpace(searchMessageBox.Text))
                    {
                        orMessages = orMessages.Union(textFiltered).ToList();
                        messages = orMessages;
                    }
                    if (fromDateTimePick.Checked || toDateTimePick.Checked)
                    {
                        orMessages = orMessages.Union(dateFiltered).ToList();
                        messages = orMessages;
                    }
                }
            }

            return messages;
        }

        private List<PhoneMessage> ContactFilter(List<PhoneMessage> messages) {
            var selected = contactComboBox.SelectedItem;
            if (selected != null) {
                messages = messages.Where(m => m.UserContact.GetContact().Equals(selected.ToString())).ToList();
            }

            return messages;
        }

        private List<PhoneMessage> TextFilter(List<PhoneMessage> messages) {
            if (!string.IsNullOrWhiteSpace(searchMessageBox.Text)) {
                string searchText = searchMessageBox.Text;
                messages = messages.Where(m => m.Text.Contains(searchText)).ToList();
            }

            return messages;
        }

        private List<PhoneMessage> DateFilter(List<PhoneMessage> messages)
        {
            if (fromDateTimePick.Checked) {
                messages = messages.Where(m => m.ReceiveDateTime >= fromDateTimePick.Value).ToList();
            }

            if (toDateTimePick.Checked && (toDateTimePick.Value >= fromDateTimePick.Value)) {
                messages = messages.Where(m => m.ReceiveDateTime <= toDateTimePick.Value).ToList();
            }

            return messages;
        }

        private void contactComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void contactComboBox_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(contactComboBox.Text))
            {
                SetMessageSettings();
                contactComboBox.Text = "Select Contact";
                //simCorpMobile.MessageStorage.ShowPhoneMessages();
            }
        }

        private void searchMessageBox_TextChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void fromDateTimePick_ValueChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void toDateTimePick_ValueChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void andFilterRBtn_CheckedChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void orFilterRBtn_CheckedChanged(object sender, EventArgs e) {
            SetMessageSettings();
            //simCorpMobile.MessageStorage.ShowPhoneMessages();
        }

        private void startMsgBtn_Click(object sender, EventArgs e) {
            smsTimer.Enabled = true;
        }

        private void stopMsgBtn_Click(object sender, EventArgs e) {
            smsTimer.Enabled = false;
        }
    }
}
