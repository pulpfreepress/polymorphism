using System;

namespace FleetSim.Weapons {

    public abstract class Weapon {

        private String _model = null;

        public Weapon(String model) {
            _model = model;
            Console.WriteLine("Weapon object created!");
        }

        public abstract void TrainWeapon();
        public abstract void FireWeapon();

        public override String ToString() { return "Weapon model: " + _model; }

    } // End Weapon
} // End namespace
