namespace MobilePhoneWinForms {
    partial class mobilePhoneWin {
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
            this.mobileInfoBtn = new System.Windows.Forms.Button();
            this.mobileOutBox = new System.Windows.Forms.TextBox();
            this.accessoryGrp = new System.Windows.Forms.GroupBox();
            this.usbAccessGrp = new System.Windows.Forms.GroupBox();
            this.applyUsbBtn = new System.Windows.Forms.Button();
            this.usbDisplayBtn = new System.Windows.Forms.RadioButton();
            this.flashLightBtn = new System.Windows.Forms.RadioButton();
            this.chargerBtn = new System.Windows.Forms.RadioButton();
            this.audioAccessGrp = new System.Windows.Forms.GroupBox();
            this.applyAudioBtn = new System.Windows.Forms.Button();
            this.samsungSetBtn = new System.Windows.Forms.RadioButton();
            this.portableSpeakerBtn = new System.Windows.Forms.RadioButton();
            this.noNameSetBtn = new System.Windows.Forms.RadioButton();
            this.iPhoneSetBtn = new System.Windows.Forms.RadioButton();
            this.smsApp = new System.Windows.Forms.GroupBox();
            this.notificationBox = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.startMsgBtn = new System.Windows.Forms.Button();
            this.stopMsgBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.smsListView = new System.Windows.Forms.ListView();
            this.contactsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.orFilterRBtn = new System.Windows.Forms.RadioButton();
            this.andFilterRBtn = new System.Windows.Forms.RadioButton();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.searchMessageBox = new System.Windows.Forms.TextBox();
            this.contactComboBox = new System.Windows.Forms.ComboBox();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.chargeBox = new System.Windows.Forms.GroupBox();
            this.chargeProgress = new System.Windows.Forms.ProgressBar();
            this.chargeStartBtn = new System.Windows.Forms.Button();
            this.chargeStopBtn = new System.Windows.Forms.Button();
            this.accessoryGrp.SuspendLayout();
            this.usbAccessGrp.SuspendLayout();
            this.audioAccessGrp.SuspendLayout();
            this.smsApp.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.chargeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mobileInfoBtn
            // 
            this.mobileInfoBtn.Location = new System.Drawing.Point(13, 13);
            this.mobileInfoBtn.Name = "mobileInfoBtn";
            this.mobileInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.mobileInfoBtn.TabIndex = 0;
            this.mobileInfoBtn.Text = "Mobile Info";
            this.mobileInfoBtn.UseVisualStyleBackColor = true;
            this.mobileInfoBtn.Click += new System.EventHandler(this.mobileInfoBtn_Click);
            // 
            // mobileOutBox
            // 
            this.mobileOutBox.Location = new System.Drawing.Point(13, 42);
            this.mobileOutBox.Multiline = true;
            this.mobileOutBox.Name = "mobileOutBox";
            this.mobileOutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mobileOutBox.Size = new System.Drawing.Size(372, 162);
            this.mobileOutBox.TabIndex = 1;
            // 
            // accessoryGrp
            // 
            this.accessoryGrp.Controls.Add(this.usbAccessGrp);
            this.accessoryGrp.Controls.Add(this.audioAccessGrp);
            this.accessoryGrp.Location = new System.Drawing.Point(13, 210);
            this.accessoryGrp.Name = "accessoryGrp";
            this.accessoryGrp.Size = new System.Drawing.Size(372, 164);
            this.accessoryGrp.TabIndex = 3;
            this.accessoryGrp.TabStop = false;
            this.accessoryGrp.Text = "Available Accessories";
            // 
            // usbAccessGrp
            // 
            this.usbAccessGrp.Controls.Add(this.applyUsbBtn);
            this.usbAccessGrp.Controls.Add(this.usbDisplayBtn);
            this.usbAccessGrp.Controls.Add(this.flashLightBtn);
            this.usbAccessGrp.Controls.Add(this.chargerBtn);
            this.usbAccessGrp.Location = new System.Drawing.Point(188, 19);
            this.usbAccessGrp.Name = "usbAccessGrp";
            this.usbAccessGrp.Size = new System.Drawing.Size(176, 140);
            this.usbAccessGrp.TabIndex = 1;
            this.usbAccessGrp.TabStop = false;
            this.usbAccessGrp.Text = "USB Accessories";
            // 
            // applyUsbBtn
            // 
            this.applyUsbBtn.Location = new System.Drawing.Point(6, 111);
            this.applyUsbBtn.Name = "applyUsbBtn";
            this.applyUsbBtn.Size = new System.Drawing.Size(75, 23);
            this.applyUsbBtn.TabIndex = 5;
            this.applyUsbBtn.Text = "Apply";
            this.applyUsbBtn.UseVisualStyleBackColor = true;
            this.applyUsbBtn.Click += new System.EventHandler(this.applyUsbBtn_Click);
            // 
            // usbDisplayBtn
            // 
            this.usbDisplayBtn.AutoSize = true;
            this.usbDisplayBtn.Location = new System.Drawing.Point(6, 65);
            this.usbDisplayBtn.Name = "usbDisplayBtn";
            this.usbDisplayBtn.Size = new System.Drawing.Size(84, 17);
            this.usbDisplayBtn.TabIndex = 2;
            this.usbDisplayBtn.Tag = "UsbDisplay";
            this.usbDisplayBtn.Text = "USB Display";
            this.usbDisplayBtn.UseVisualStyleBackColor = true;
            // 
            // flashLightBtn
            // 
            this.flashLightBtn.AutoSize = true;
            this.flashLightBtn.Location = new System.Drawing.Point(6, 42);
            this.flashLightBtn.Name = "flashLightBtn";
            this.flashLightBtn.Size = new System.Drawing.Size(72, 17);
            this.flashLightBtn.TabIndex = 1;
            this.flashLightBtn.Tag = "FlashLight";
            this.flashLightBtn.Text = "Flash light";
            this.flashLightBtn.UseVisualStyleBackColor = true;
            // 
            // chargerBtn
            // 
            this.chargerBtn.AutoSize = true;
            this.chargerBtn.Checked = true;
            this.chargerBtn.Location = new System.Drawing.Point(6, 19);
            this.chargerBtn.Name = "chargerBtn";
            this.chargerBtn.Size = new System.Drawing.Size(62, 17);
            this.chargerBtn.TabIndex = 0;
            this.chargerBtn.TabStop = true;
            this.chargerBtn.Tag = "Charger";
            this.chargerBtn.Text = "Charger";
            this.chargerBtn.UseVisualStyleBackColor = true;
            // 
            // audioAccessGrp
            // 
            this.audioAccessGrp.Controls.Add(this.applyAudioBtn);
            this.audioAccessGrp.Controls.Add(this.samsungSetBtn);
            this.audioAccessGrp.Controls.Add(this.portableSpeakerBtn);
            this.audioAccessGrp.Controls.Add(this.noNameSetBtn);
            this.audioAccessGrp.Controls.Add(this.iPhoneSetBtn);
            this.audioAccessGrp.Location = new System.Drawing.Point(6, 19);
            this.audioAccessGrp.Name = "audioAccessGrp";
            this.audioAccessGrp.Size = new System.Drawing.Size(176, 140);
            this.audioAccessGrp.TabIndex = 0;
            this.audioAccessGrp.TabStop = false;
            this.audioAccessGrp.Text = "Audio Accessories";
            // 
            // applyAudioBtn
            // 
            this.applyAudioBtn.Location = new System.Drawing.Point(6, 111);
            this.applyAudioBtn.Name = "applyAudioBtn";
            this.applyAudioBtn.Size = new System.Drawing.Size(75, 23);
            this.applyAudioBtn.TabIndex = 4;
            this.applyAudioBtn.Text = "Apply";
            this.applyAudioBtn.UseVisualStyleBackColor = true;
            this.applyAudioBtn.Click += new System.EventHandler(this.applyAudioBtn_Click);
            // 
            // samsungSetBtn
            // 
            this.samsungSetBtn.AutoSize = true;
            this.samsungSetBtn.Location = new System.Drawing.Point(6, 88);
            this.samsungSetBtn.Name = "samsungSetBtn";
            this.samsungSetBtn.Size = new System.Drawing.Size(131, 17);
            this.samsungSetBtn.TabIndex = 3;
            this.samsungSetBtn.TabStop = true;
            this.samsungSetBtn.Tag = "SamsungHeadphones";
            this.samsungSetBtn.Text = "Samsung headphones";
            this.samsungSetBtn.UseVisualStyleBackColor = true;
            // 
            // portableSpeakerBtn
            // 
            this.portableSpeakerBtn.AutoSize = true;
            this.portableSpeakerBtn.Location = new System.Drawing.Point(6, 65);
            this.portableSpeakerBtn.Name = "portableSpeakerBtn";
            this.portableSpeakerBtn.Size = new System.Drawing.Size(105, 17);
            this.portableSpeakerBtn.TabIndex = 2;
            this.portableSpeakerBtn.Tag = "PortableSpeaker";
            this.portableSpeakerBtn.Text = "Portable speaker";
            this.portableSpeakerBtn.UseVisualStyleBackColor = true;
            // 
            // noNameSetBtn
            // 
            this.noNameSetBtn.AutoSize = true;
            this.noNameSetBtn.Location = new System.Drawing.Point(6, 42);
            this.noNameSetBtn.Name = "noNameSetBtn";
            this.noNameSetBtn.Size = new System.Drawing.Size(109, 17);
            this.noNameSetBtn.TabIndex = 1;
            this.noNameSetBtn.Tag = "NoNameHeadset";
            this.noNameSetBtn.Text = "No name headset";
            this.noNameSetBtn.UseVisualStyleBackColor = true;
            // 
            // iPhoneSetBtn
            // 
            this.iPhoneSetBtn.AutoSize = true;
            this.iPhoneSetBtn.Checked = true;
            this.iPhoneSetBtn.Location = new System.Drawing.Point(6, 19);
            this.iPhoneSetBtn.Name = "iPhoneSetBtn";
            this.iPhoneSetBtn.Size = new System.Drawing.Size(99, 17);
            this.iPhoneSetBtn.TabIndex = 0;
            this.iPhoneSetBtn.TabStop = true;
            this.iPhoneSetBtn.Tag = "HeadsetIPhone";
            this.iPhoneSetBtn.Text = "iPhone headset";
            this.iPhoneSetBtn.UseVisualStyleBackColor = true;
            // 
            // smsApp
            // 
            this.smsApp.Controls.Add(this.notificationBox);
            this.smsApp.Controls.Add(this.msgLabel);
            this.smsApp.Controls.Add(this.startMsgBtn);
            this.smsApp.Controls.Add(this.stopMsgBtn);
            this.smsApp.Controls.Add(this.searchLabel);
            this.smsApp.Controls.Add(this.smsListView);
            this.smsApp.Controls.Add(this.filterGroupBox);
            this.smsApp.Controls.Add(this.toLabel);
            this.smsApp.Controls.Add(this.fromLabel);
            this.smsApp.Controls.Add(this.toDateTimePick);
            this.smsApp.Controls.Add(this.fromDateTimePick);
            this.smsApp.Controls.Add(this.searchMessageBox);
            this.smsApp.Controls.Add(this.contactComboBox);
            this.smsApp.Controls.Add(this.formatComboBox);
            this.smsApp.Location = new System.Drawing.Point(391, 13);
            this.smsApp.Name = "smsApp";
            this.smsApp.Size = new System.Drawing.Size(372, 471);
            this.smsApp.TabIndex = 4;
            this.smsApp.TabStop = false;
            this.smsApp.Text = "SMS Application";
            // 
            // notificationBox
            // 
            this.notificationBox.Location = new System.Drawing.Point(139, 443);
            this.notificationBox.Name = "notificationBox";
            this.notificationBox.Size = new System.Drawing.Size(227, 20);
            this.notificationBox.TabIndex = 14;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(6, 446);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(33, 13);
            this.msgLabel.TabIndex = 13;
            this.msgLabel.Text = "SMS:";
            // 
            // startMsgBtn
            // 
            this.startMsgBtn.Location = new System.Drawing.Point(43, 441);
            this.startMsgBtn.Name = "startMsgBtn";
            this.startMsgBtn.Size = new System.Drawing.Size(42, 23);
            this.startMsgBtn.TabIndex = 12;
            this.startMsgBtn.Text = "Start";
            this.startMsgBtn.UseVisualStyleBackColor = true;
            this.startMsgBtn.Click += new System.EventHandler(this.startMsgBtn_Click);
            // 
            // stopMsgBtn
            // 
            this.stopMsgBtn.Location = new System.Drawing.Point(91, 441);
            this.stopMsgBtn.Name = "stopMsgBtn";
            this.stopMsgBtn.Size = new System.Drawing.Size(42, 23);
            this.stopMsgBtn.TabIndex = 11;
            this.stopMsgBtn.Text = "Stop";
            this.stopMsgBtn.UseVisualStyleBackColor = true;
            this.stopMsgBtn.Click += new System.EventHandler(this.stopMsgBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(161, 49);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 10;
            this.searchLabel.Text = "Search";
            // 
            // smsListView
            // 
            this.smsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contactsCol,
            this.messageCol});
            this.smsListView.Location = new System.Drawing.Point(6, 124);
            this.smsListView.Name = "smsListView";
            this.smsListView.Size = new System.Drawing.Size(360, 309);
            this.smsListView.TabIndex = 9;
            this.smsListView.UseCompatibleStateImageBehavior = false;
            this.smsListView.View = System.Windows.Forms.View.Tile;
            // 
            // contactsCol
            // 
            this.contactsCol.Text = "Contact";
            // 
            // messageCol
            // 
            this.messageCol.Text = "Message";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.orFilterRBtn);
            this.filterGroupBox.Controls.Add(this.andFilterRBtn);
            this.filterGroupBox.Location = new System.Drawing.Point(59, 45);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(96, 72);
            this.filterGroupBox.TabIndex = 8;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filter Combining";
            // 
            // orFilterRBtn
            // 
            this.orFilterRBtn.AutoSize = true;
            this.orFilterRBtn.Location = new System.Drawing.Point(49, 42);
            this.orFilterRBtn.Name = "orFilterRBtn";
            this.orFilterRBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orFilterRBtn.Size = new System.Drawing.Size(41, 17);
            this.orFilterRBtn.TabIndex = 1;
            this.orFilterRBtn.TabStop = true;
            this.orFilterRBtn.Text = "OR";
            this.orFilterRBtn.UseVisualStyleBackColor = true;
            this.orFilterRBtn.CheckedChanged += new System.EventHandler(this.orFilterRBtn_CheckedChanged);
            // 
            // andFilterRBtn
            // 
            this.andFilterRBtn.AutoSize = true;
            this.andFilterRBtn.Checked = true;
            this.andFilterRBtn.Location = new System.Drawing.Point(42, 19);
            this.andFilterRBtn.Name = "andFilterRBtn";
            this.andFilterRBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.andFilterRBtn.Size = new System.Drawing.Size(48, 17);
            this.andFilterRBtn.TabIndex = 0;
            this.andFilterRBtn.TabStop = true;
            this.andFilterRBtn.Text = "AND";
            this.andFilterRBtn.UseVisualStyleBackColor = true;
            this.andFilterRBtn.CheckedChanged += new System.EventHandler(this.andFilterRBtn_CheckedChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(161, 104);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "To";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(161, 78);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 6;
            this.fromLabel.Text = "From";
            // 
            // toDateTimePick
            // 
            this.toDateTimePick.Checked = false;
            this.toDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.toDateTimePick.Location = new System.Drawing.Point(208, 98);
            this.toDateTimePick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.toDateTimePick.Name = "toDateTimePick";
            this.toDateTimePick.ShowCheckBox = true;
            this.toDateTimePick.Size = new System.Drawing.Size(158, 20);
            this.toDateTimePick.TabIndex = 5;
            this.toDateTimePick.Value = new System.DateTime(2019, 9, 9, 0, 0, 0, 0);
            this.toDateTimePick.ValueChanged += new System.EventHandler(this.toDateTimePick_ValueChanged);
            // 
            // fromDateTimePick
            // 
            this.fromDateTimePick.Checked = false;
            this.fromDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fromDateTimePick.Location = new System.Drawing.Point(208, 72);
            this.fromDateTimePick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePick.Name = "fromDateTimePick";
            this.fromDateTimePick.ShowCheckBox = true;
            this.fromDateTimePick.Size = new System.Drawing.Size(158, 20);
            this.fromDateTimePick.TabIndex = 4;
            this.fromDateTimePick.Tag = "";
            this.fromDateTimePick.Value = new System.DateTime(2019, 9, 9, 0, 0, 0, 0);
            this.fromDateTimePick.ValueChanged += new System.EventHandler(this.fromDateTimePick_ValueChanged);
            // 
            // searchMessageBox
            // 
            this.searchMessageBox.Location = new System.Drawing.Point(208, 46);
            this.searchMessageBox.Name = "searchMessageBox";
            this.searchMessageBox.Size = new System.Drawing.Size(158, 20);
            this.searchMessageBox.TabIndex = 3;
            this.searchMessageBox.TextChanged += new System.EventHandler(this.searchMessageBox_TextChanged);
            // 
            // contactComboBox
            // 
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(208, 19);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(158, 21);
            this.contactComboBox.TabIndex = 2;
            this.contactComboBox.Text = "Select Contact";
            this.contactComboBox.SelectedIndexChanged += new System.EventHandler(this.contactComboBox_SelectedIndexChanged);
            this.contactComboBox.TextChanged += new System.EventHandler(this.contactComboBox_TextChanged);
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "None",
            "Start with date",
            "End with date",
            "Lower case",
            "Upper case",
            "Start with time"});
            this.formatComboBox.Location = new System.Drawing.Point(6, 19);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(149, 21);
            this.formatComboBox.TabIndex = 1;
            this.formatComboBox.Text = "Select Formatting";
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // chargeBox
            // 
            this.chargeBox.Controls.Add(this.chargeStopBtn);
            this.chargeBox.Controls.Add(this.chargeStartBtn);
            this.chargeBox.Controls.Add(this.chargeProgress);
            this.chargeBox.Location = new System.Drawing.Point(13, 375);
            this.chargeBox.Name = "chargeBox";
            this.chargeBox.Size = new System.Drawing.Size(372, 109);
            this.chargeBox.TabIndex = 5;
            this.chargeBox.TabStop = false;
            this.chargeBox.Text = "Charging";
            // 
            // chargeProgress
            // 
            this.chargeProgress.Location = new System.Drawing.Point(6, 19);
            this.chargeProgress.Name = "chargeProgress";
            this.chargeProgress.Size = new System.Drawing.Size(360, 23);
            this.chargeProgress.TabIndex = 0;
            // 
            // chargeStartBtn
            // 
            this.chargeStartBtn.Location = new System.Drawing.Point(6, 48);
            this.chargeStartBtn.Name = "chargeStartBtn";
            this.chargeStartBtn.Size = new System.Drawing.Size(75, 23);
            this.chargeStartBtn.TabIndex = 1;
            this.chargeStartBtn.Text = "Charge Start";
            this.chargeStartBtn.UseVisualStyleBackColor = true;
            this.chargeStartBtn.Click += new System.EventHandler(this.chargeStartBtn_Click);
            // 
            // chargeStopBtn
            // 
            this.chargeStopBtn.Location = new System.Drawing.Point(87, 48);
            this.chargeStopBtn.Name = "chargeStopBtn";
            this.chargeStopBtn.Size = new System.Drawing.Size(75, 23);
            this.chargeStopBtn.TabIndex = 2;
            this.chargeStopBtn.Text = "Charge Stop";
            this.chargeStopBtn.UseVisualStyleBackColor = true;
            this.chargeStopBtn.Click += new System.EventHandler(this.chargeStopBtn_Click);
            // 
            // mobilePhoneWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 489);
            this.Controls.Add(this.chargeBox);
            this.Controls.Add(this.smsApp);
            this.Controls.Add(this.accessoryGrp);
            this.Controls.Add(this.mobileOutBox);
            this.Controls.Add(this.mobileInfoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mobilePhoneWin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Mobile Phone";
            this.accessoryGrp.ResumeLayout(false);
            this.usbAccessGrp.ResumeLayout(false);
            this.usbAccessGrp.PerformLayout();
            this.audioAccessGrp.ResumeLayout(false);
            this.audioAccessGrp.PerformLayout();
            this.smsApp.ResumeLayout(false);
            this.smsApp.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.chargeBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mobileInfoBtn;
        private System.Windows.Forms.TextBox mobileOutBox;
        private System.Windows.Forms.GroupBox accessoryGrp;
        private System.Windows.Forms.GroupBox usbAccessGrp;
        private System.Windows.Forms.RadioButton usbDisplayBtn;
        private System.Windows.Forms.RadioButton flashLightBtn;
        private System.Windows.Forms.RadioButton chargerBtn;
        private System.Windows.Forms.GroupBox audioAccessGrp;
        private System.Windows.Forms.RadioButton samsungSetBtn;
        private System.Windows.Forms.RadioButton portableSpeakerBtn;
        private System.Windows.Forms.RadioButton noNameSetBtn;
        private System.Windows.Forms.RadioButton iPhoneSetBtn;
        private System.Windows.Forms.Button applyUsbBtn;
        private System.Windows.Forms.Button applyAudioBtn;
        private System.Windows.Forms.GroupBox smsApp;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePick;
        private System.Windows.Forms.DateTimePicker fromDateTimePick;
        private System.Windows.Forms.TextBox searchMessageBox;
        private System.Windows.Forms.ComboBox contactComboBox;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.RadioButton orFilterRBtn;
        private System.Windows.Forms.RadioButton andFilterRBtn;
        private System.Windows.Forms.ListView smsListView;
        private System.Windows.Forms.ColumnHeader contactsCol;
        private System.Windows.Forms.ColumnHeader messageCol;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox notificationBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button startMsgBtn;
        private System.Windows.Forms.Button stopMsgBtn;
        private System.Windows.Forms.GroupBox chargeBox;
        private System.Windows.Forms.Button chargeStopBtn;
        private System.Windows.Forms.Button chargeStartBtn;
        private System.Windows.Forms.ProgressBar chargeProgress;
    }
}

