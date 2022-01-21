using System;

namespace FleetSim.Weapons {

    public class CIWS : Weapon {

        public CIWS(String model) : base(model) {
            Console.WriteLine("CIWS object created!");
        }

        public override void TrainWeapon() {
            Console.WriteLine("CIWS is locked on target!");
        }

        public override void FireWeapon() {
            Console.WriteLine("The CIWS roars to life and fires a zillion bullets at the target!");
        }

    } // End CIWS
} // End namespace
