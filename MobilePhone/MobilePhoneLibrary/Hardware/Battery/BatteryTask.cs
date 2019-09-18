using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLibrary.Hardware.Battery {
    public class BatteryTask : Battery {
        public BatteryTask(int capacity, int chargingTime, IUserInOut userInOut)
            : base(capacity, chargingTime, userInOut) { }

        public override void Discharge(int delay) {
            var dischargeTask = new Action(async () => {
                while (CanDischarge) {
                    await Task.Run(async () => {
                        await Task.Delay(delay);
                        lock (SyncObject) {
                            if (Charge > 0) { Charge--; }
                            ShowCharge?.Invoke(this, Charge);
                        }
                    });
                }
            });

            dischargeTask.Invoke();
        }

        public override void StartCharge(int delay) {
            var chargeTask = new Action(async () => {
                CanCharge = true;
                while (CanCharge) {
                    await Task.Run(async () => {
                        await Task.Delay(delay);
                        lock (SyncObject) {
                            if (Charge < MaxCharge) {
                                Charge++;
                            } else { StopCharge(); }
                            ShowCharge?.Invoke(this, Charge);
                        }
                    });
                }
            });

            chargeTask.Invoke();
        }
    }
}
