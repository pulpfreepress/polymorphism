using System;
using FleetSim.PowerPlants;
using FleetSim.Weapons;

namespace FleetSim.Vessels {

    public class Submarine : Vessel {

        public Submarine(PowerPlant plant, Weapon weapon, String name) : base(plant, weapon, name) {
            Console.WriteLine("Submarine object created: " + base.ToString());
        }

        public override void LightoffPlant() {
            Plant.LightoffPlant();
        }

        public override void ShutdownPlant() {
            Plant.ShutdownPlant();
        }

        public override void TrainWeapon() {
            Weapon.TrainWeapon();
        }

        public override void FireWeapon() {
            Weapon.FireWeapon();
        }

    } // end Submarine
} // End namespace
