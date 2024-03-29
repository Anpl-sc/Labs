﻿using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhoneLibrary.Accessories.Audio;
using MobilePhoneLibrary.Accessories.Usb;
using MobilePhoneLibrary.Hardware.AudioInOut;
using MobilePhoneLibrary.Hardware.Battery;
using MobilePhoneLibrary.Hardware.CellularModule;
using MobilePhoneLibrary.Hardware.Screen;
using MobilePhoneLibrary.Hardware.UserControl;
using MobilePhoneLibrary.Services;
using MobilePhoneLibrary.Services.SMS;

namespace MobilePhoneLibrary {
    public abstract class Mobile{
        private IUserInOut userInOut;

        protected Mobile(IUserInOut userInOut) {
            this.userInOut = userInOut;
        }

        public abstract Microphone Microphone { get; }
        private void TransmitSound(ISound sound) {
            Microphone.TransmitSound(sound);
        }
        private void RecordSound(ISound sound) {
            Microphone.RecordSound(sound);
        }

        public abstract Speaker Speaker { get; }
        private void PlaySound(ISound sound) {
            Speaker.PlaySound(sound);
        }

        public abstract Battery Battery { get; }
        private void PowerSupply(IPowerProfile profile) {
            Battery.PowerSupply(profile);
        }

        public abstract CellularModule CellModule { get; }
        private void TransmitPackage(ICellularPackage package) {
            CellModule.TransmitPackage(package);
        }
        private void ReceivePackage(ICellularPackage package) {
            CellModule.ReceivePackage(package);
        }

        public abstract Screen Screen { get; }
        private void Show(IScreenImage screenImage) {
            Screen.Show(screenImage);
        }

        public abstract UserControl Control { get; }
        private void ParseInput(IUserInput input) {
            Control.ParseInput(input);
        }

        public abstract MessageStorage MessageStorage { get; }
        internal abstract SMSProvider SMSProvider { get; }

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}\r\n" + 
                                          $"Speaker Type: {Speaker.ToString()}\r\n" +
                                          $"Battery Type: {Battery.ToString()}\r\n" +
                                          $"Cell Module Type: {CellModule.ToString()}\r\n" +
                                          $"Screen Type: {Screen.ToString()}\r\n" +
                                          $"User control Type: {Control.ToString()}");
            return descriptionBuilder.ToString();
        }

        public IAudio AudioComponent { get; set; }
        public void Play(object data) {
            AudioComponent.Play(data);
        }
        public object Record() {
            IAudioInOut audioInOut = AudioComponent as IAudioInOut;
            if (audioInOut != null) {
                return audioInOut.Record();
            } else {
                return "Record function is not available";
            }
        }

        public IUsb UsbDevice { get; set; }
        public void PowerSupply(object data) {
            UsbDevice.PowerSupply(data);
        }
        public void DataTransfer(object data) {
            IDataDeice dataDeice = UsbDevice as IDataDeice;
            if (dataDeice != null) {
                dataDeice.DataTransfer(data);
            } else {
                userInOut.WriteLine("Data transferring function is not available");
            }
        }

        private int AudioAccessoryChoice() {
            string choiceName = "Audio Accessory:";
            string[] choiceVariants = { nameof(HeadsetIPhone), nameof(NoNameHeadset), nameof(PortableSpeaker), nameof(SamsungHeadphones) };
            return userInOut.ReadChoice(choiceName, choiceVariants);
        }

        private void GetAudioAccessory(int choice) {
            switch (choice) {
                case 1:
                    AudioComponent = new HeadsetIPhone(userInOut);
                    break;
                case 2:
                    AudioComponent = new NoNameHeadset(userInOut);
                    break;
                case 3:
                    AudioComponent = new PortableSpeaker(userInOut);
                    break;
                case 4:
                    int soundImprovingRate = 53;
                    AudioComponent = new SamsungHeadphones(soundImprovingRate, userInOut);
                    break;
            }
        }

        public void SetAudioAccessory() {
            int audioAccessory = AudioAccessoryChoice();
            if (audioAccessory > 0) {
                GetAudioAccessory(audioAccessory);
                userInOut.WriteLine($"Selected {AudioComponent}");
                string sound = "Some sound";
                Play(sound);
                userInOut.WriteLine(Record().ToString() + "\r\n");
            }
        }

        private int UsbAccessoryChoice() {
            string choiceName = "USB Accessory:";
            string[] choiceVariants = { nameof(Charger), nameof(FlashLight), nameof(UsbDisplay) };
            return userInOut.ReadChoice(choiceName, choiceVariants);
        }

        private void GetUsbAccessory(int choice) {
            switch (choice) {
                case 1:
                    UsbDevice = new Charger(userInOut);
                    break;
                case 2:
                    UsbDevice = new FlashLight(userInOut);
                    break;
                case 3:
                    UsbDevice = new UsbDisplay(userInOut);
                    break;
            }
        }

        public void SetUsbAccessory() {
            int usbAccessory = UsbAccessoryChoice();
            if (usbAccessory > 0) {
                GetUsbAccessory(usbAccessory);
                userInOut.WriteLine($"Selected {UsbDevice}");
                string power = "Power supplied";
                PowerSupply(power);
                string data = "Transfering data";
                DataTransfer(data);
                userInOut.WriteLine("");
            }
        }

        public void MessagesStart() {
            SMSProvider.Generate += (s, m) => MessageStorage.AddMessage(m);
            SMSProvider.Start(MessageStorage.Contacts);
        }

        public void MessageStop() {
            SMSProvider.Stop();
        }
    }
}
