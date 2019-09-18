using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Hardware.Battery {
    public class BatteryThread : Battery {
        public BatteryThread(int capacity, int chargingTime, IUserInOut userInOut)
            : base(capacity, chargingTime, userInOut) { }

        public override void Discharge(int delay) {
            Thread dischargeThread = new Thread(() => {
                while (CanDischarge) {
                    Thread.Sleep(delay);
                    lock (SyncObject) {
                        if (Charge > 0) { Charge--; }
                        ShowCharge?.Invoke(this, Charge);
                    }
                }
            });

            dischargeThread.Start();
        }

        public override void StartCharge(int delay) {
            Thread chargeThread = new Thread(() => {
                CanCharge = true;
                while (CanCharge) {
                    Thread.Sleep(delay);
                    lock (SyncObject) {
                        if (Charge < MaxCharge) {
                            Charge++;
                        } else { StopCharge(); }
                        ShowCharge?.Invoke(this, Charge);
                    }
                }

            });

            chargeThread.Start();
        }
    }
}
