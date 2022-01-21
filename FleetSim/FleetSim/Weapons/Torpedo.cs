using System;
namespace FleetSim.Weapons {

    public class Torpedo : Weapon {

        public Torpedo(String model) : base(model) {
            Console.WriteLine("Torpedo object created!");
        }

        public override void TrainWeapon() {
            Console.WriteLine("Torpedo is locked on target!");
        }

        public override void FireWeapon() {
            Console.WriteLine("Fish in the water, heading towards target!");
        }

    } // End Torpedo
} // End namespace
