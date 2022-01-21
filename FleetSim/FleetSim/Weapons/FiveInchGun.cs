using System;
namespace FleetSim.Weapons {

    public class FiveInchGun : Weapon {

        public FiveInchGun(String model) : base(model) {
            Console.WriteLine("FiveInchGun object created!");
        }

        public override void TrainWeapon() {
            Console.WriteLine("Five Inch Gun is locked on target!");
        }

        public override void FireWeapon() {
            Console.WriteLine("Blam! Blam! Blam!");
        }

    } // End FiveInchGun
} // End namespace
