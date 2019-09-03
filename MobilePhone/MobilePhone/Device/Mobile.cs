using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Device.Accessories.Audio;
using MobilePhone.Device.Accessories.Usb;
using MobilePhone.Device.Hardware.AudioInOut;
using MobilePhone.Device.Hardware.Battery;
using MobilePhone.Device.Hardware.CellularModule;
using MobilePhone.Device.Hardware.Screen;
using MobilePhone.Device.Hardware.UserControl;

namespace MobilePhone.Device {
    public abstract class Mobile{
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

        public override string ToString() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}\n" + 
                                          $"Speaker Type: {Speaker.ToString()}\n" +
                                          $"Battery Type: {Battery.ToString()}\n" +
                                          $"Cell Module Type: {CellModule.ToString()}\n" +
                                          $"Screen Type: {Screen.ToString()}\n" +
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
                Console.WriteLine("Data transferring function is not available");
            }
        }

        private string AudioAccessoryChoise() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Select audio Accessory:\n" +
                                          $"1 - {nameof(HeadsetIPhone)}\n" +
                                          $"2 - {nameof(NoNameHeadset)}\n" +
                                          $"3 - {nameof(PortableSpeaker)}\n" +
                                          $"4 - {nameof(SamsungHeadphones)}\n");
            return descriptionBuilder.ToString();
        }

        private void GetAudioAccessory(int choise) {
            switch (choise) {
                case 1:
                    AudioComponent = new HeadsetIPhone();
                    break;
                case 2:
                    AudioComponent = new NoNameHeadset();
                    break;
                case 3:
                    AudioComponent = new PortableSpeaker();
                    break;
                case 4:
                    int soundImprovingRate = 53;
                    AudioComponent = new SamsungHeadphones(soundImprovingRate);
                    break;
            }
        }

        private void SetAudioAccessory()
        {
            Console.Write(AudioAccessoryChoise());
            int audioAccessory = Int32.Parse(Console.ReadLine());
            GetAudioAccessory(audioAccessory);
            Console.WriteLine($"Selected {AudioComponent}");
            string sound = "Some sound";
            Play(sound);
            Console.WriteLine(Record().ToString()+"\n");
        }

        private string UsbAccessoryChoise() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Select USB Accessory:\n" +
                                          $"1 - {nameof(Charger)}\n" +
                                          $"2 - {nameof(FlashLight)}\n" +
                                          $"3 - {nameof(UsbDisplay)}\n");
            return descriptionBuilder.ToString();
        }

        private void GetUsbAccessory(int choise) {
            switch (choise) {
                case 1:
                    UsbDevice = new Charger();
                    break;
                case 2:
                    UsbDevice = new FlashLight();
                    break;
                case 3:
                    UsbDevice = new UsbDisplay();
                    break;
            }
        }

        private void SetUsbAccessory() {
            Console.Write(UsbAccessoryChoise());
            int usbAccessory = Int32.Parse(Console.ReadLine());
            GetUsbAccessory(usbAccessory);
            Console.WriteLine($"Selected {UsbDevice}");
            string power = "Power supplied";
            PowerSupply(power);
            string data = "Transfering data";
            DataTransfer(data);
            Console.WriteLine("");
        }

        public void SetAccessories() {
            SetAudioAccessory();
            SetUsbAccessory();
        }
    }
}
