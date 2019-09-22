namespace MobilePhoneWinForms {
    partial class CallsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.callsListView = new System.Windows.Forms.ListView();
            this.phoneCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // callsListView
            // 
            this.callsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.phoneCol,
            this.timeCol});
            this.callsListView.FullRowSelect = true;
            this.callsListView.Location = new System.Drawing.Point(12, 12);
            this.callsListView.Name = "callsListView";
            this.callsListView.Size = new System.Drawing.Size(510, 487);
            this.callsListView.TabIndex = 0;
            this.callsListView.UseCompatibleStateImageBehavior = false;
            this.callsListView.View = System.Windows.Forms.View.Details;
            // 
            // phoneCol
            // 
            this.phoneCol.Text = "Phone";
            // 
            // timeCol
            // 
            this.timeCol.Text = "Time";
            // 
            // CallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.callsListView);
            this.Name = "CallsForm";
            this.Text = "CallsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView callsListView;
        private System.Windows.Forms.ColumnHeader phoneCol;
        private System.Windows.Forms.ColumnHeader timeCol;
    }
}