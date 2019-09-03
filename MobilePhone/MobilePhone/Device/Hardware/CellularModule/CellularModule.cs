using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.UserInOut;

namespace MobilePhone.Device.Hardware.CellularModule {
    public class CellularModule{
        private IUserInOut userInOut;

        public CellularType ModuleType { get; }
        public int WorkingDistance { get; }

        public CellularModule(CellularType moduleType, int workingDistance, IUserInOut userInOut) {
            ModuleType = moduleType;
            WorkingDistance = workingDistance;
            this.userInOut = userInOut;
        }

        public void TransmitPackage(ICellularPackage package) {
            userInOut.WriteLine("Transmit " + package.PackageType + " package\n");
        }

        public void ReceivePackage(ICellularPackage package) {
            userInOut.WriteLine("Received " + package.PackageType + " package\n");
        }

        public override string ToString() {
            return "Cellular module, ModuleType " + ModuleType + ", WorkingDistance " + WorkingDistance;
        }
    }
}
