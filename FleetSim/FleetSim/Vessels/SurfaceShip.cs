using System;
using FleetSim.Weapons;
using FleetSim.PowerPlants;

namespace FleetSim.Vessels {

    public class SurfaceShip : Vessel {

        public SurfaceShip(PowerPlant plant, Weapon weapon, String name) : base(plant, weapon, name) {
            Console.WriteLine("SurfaceShip object created: " + base.ToString());
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

    } // End SurfaceShip
} // End namespace
