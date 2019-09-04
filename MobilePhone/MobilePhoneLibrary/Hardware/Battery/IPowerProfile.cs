namespace MobilePhoneLibrary.Hardware.Battery {
    public interface IPowerProfile {
        int Voltage { get; set; }
        int OutputCurrency { get; set; }
    }
}