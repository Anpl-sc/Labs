using System;
using System.Threading;

namespace MobilePhoneLibrary.Hardware.Battery {
    public class Battery{
        public EventHandler<int> ShowCharge;

        private IUserInOut userInOut;

        private volatile bool vCanCharge;
        private volatile bool vCanDischarge;
        public bool CanCharge {
            get { return vCanCharge; }
            set { vCanCharge = value; }
        }

        public bool CanDischarge
        {
            get { return vCanDischarge; }
            set { vCanDischarge = value; }
        }

        protected const int MaxCharge = 100;
        public int Charge { get; set; }

        public object SyncObject { get; set; } = new object();

        public int Capacity { get; }
        public int ChargingTime { get; }
        
        public Battery(int capacity, int chargingTime, IUserInOut userInOut) {
            Capacity = capacity;
            ChargingTime = chargingTime;
            this.userInOut = userInOut;
            Charge = MaxCharge/2;
            CanDischarge = true;
        }

        public void PowerSupply(IPowerProfile powerProfile) {
            userInOut.WriteLine("Power supplying with voltage " + powerProfile.Voltage + ", and currency " + powerProfile.OutputCurrency +"\n");
        }

        public override string ToString() {
            return "Device battery, Capacity " + Capacity + ", ChargingTime " + ChargingTime;
        }

        public virtual void Discharge(int delay) {
            while (CanDischarge) {
                Thread.Sleep(delay);
                lock (SyncObject) {
                    if (Charge > 0) {
                        Charge--;
                    }
                    ShowCharge?.Invoke(this, Charge);
                }
            }
        }

        public virtual void StartCharge(int delay) {
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
        }

        public void StopCharge() {
            CanCharge = false;
        }
    }
}
