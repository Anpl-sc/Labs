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
            this.ApplyUsbBtn = new System.Windows.Forms.Button();
            this.usbDisplayBtn = new System.Windows.Forms.RadioButton();
            this.flashLightBtn = new System.Windows.Forms.RadioButton();
            this.chargerBtn = new System.Windows.Forms.RadioButton();
            this.audioAccessGrp = new System.Windows.Forms.GroupBox();
            this.applyAudioBtn = new System.Windows.Forms.Button();
            this.samsungSetBtn = new System.Windows.Forms.RadioButton();
            this.portableSpeakerBtn = new System.Windows.Forms.RadioButton();
            this.noNameSetBtn = new System.Windows.Forms.RadioButton();
            this.iPhoneSetBtn = new System.Windows.Forms.RadioButton();
            this.accessoryGrp.SuspendLayout();
            this.usbAccessGrp.SuspendLayout();
            this.audioAccessGrp.SuspendLayout();
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
            this.usbAccessGrp.Controls.Add(this.ApplyUsbBtn);
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
            // ApplyUsbBtn
            // 
            this.ApplyUsbBtn.Location = new System.Drawing.Point(6, 111);
            this.ApplyUsbBtn.Name = "ApplyUsbBtn";
            this.ApplyUsbBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyUsbBtn.TabIndex = 5;
            this.ApplyUsbBtn.Text = "Apply";
            this.ApplyUsbBtn.UseVisualStyleBackColor = true;
            this.ApplyUsbBtn.Click += new System.EventHandler(this.ApplyUsbBtn_Click);
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
            // mobilePhoneWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 378);
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
        private System.Windows.Forms.Button ApplyUsbBtn;
        private System.Windows.Forms.Button applyAudioBtn;
    }
}

