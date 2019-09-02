using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Device.Hardware.CellularModule {
    public class CellularModule{
        public CellularType ModuleType { get; }
        public int WorkingDistance { get; }

        public CellularModule(CellularType moduleType, int workingDistance) {
            ModuleType = moduleType;
            WorkingDistance = workingDistance;
        }

        public void TransmitPackage(ICellularPackage package) {
            Console.WriteLine("Transmit " + package.PackageType + " package\n");
        }

        public void ReceivePackage(ICellularPackage package) {
            Console.WriteLine("Received " + package.PackageType + " package\n");
        }

        public override string ToString() {
            return "Cellular module, ModuleType " + ModuleType + ", WorkingDistance " + WorkingDistance;
        }
    }
}
