using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                                          $"User control Type: {Control.ToString()}\n");
            return descriptionBuilder.ToString();
        }
    }
}
