﻿namespace MobilePhone.Device.Hardware.UserControl {
    public interface IUserInput {
        bool InputAllowed { get; set; }
        string UserInputInfo { get; set; }
    }
}