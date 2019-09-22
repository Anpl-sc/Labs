using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhoneLibrary.Services.Calls;

namespace MobilePhoneWinForms {
    public partial class CallsForm : Form {
        public CallsForm() {
            InitializeComponent();
            InitializeCalls();
        }

        private void InitializeCalls() {
            CallsProvider callsProvider = new CallsProvider();
            callsProvider.Show += ShowCalls;
        }

        private void ShowCalls(object sender, List<Call> calls) {
            callsListView.Items.Clear();
            callsListView.Groups.Clear();
            ListViewGroup group = new ListViewGroup();

            for (int i = 0; i < calls.Count; i++) {
                Call call = calls[i];
                if ((i == 0) || !call.Equals(calls[i-1])) {
                    group = new ListViewGroup($"{call.Contact.Name} - {call.Direction}");
                    callsListView.Groups.Add(group);
                }
                
                callsListView.Items.Add(new ListViewItem(new[] {
                    call.ContactPhone.ToString(), call.Time.ToString("mm:ss:FF")}, 
                    group));
            }
        }
    }
}
