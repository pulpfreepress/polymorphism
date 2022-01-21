using System;
using FleetSim.PowerPlants;
using FleetSim.Weapons;

namespace FleetSim.Vessels {

    public abstract class Vessel {

        private PowerPlant _plant;
        private Weapon _weapon;
        private string _name;

        public string Name {
            get => _name;
            set => _name = value;
        }

        // protected read-only properties
        protected Weapon Weapon {
            get { return _weapon; }
        }

        protected PowerPlant Plant {
            get { return _plant; }
        }

        public Vessel(PowerPlant plant, Weapon weapon, String name) {
            _weapon = weapon;
            _plant = plant;
            _name = name;
            Console.WriteLine("The vessel object created!");
        }

        /* ********************************************************
			Public Abstract Methods - must be implemented in
			derived classes.
		*********************************************************/
        public abstract void LightoffPlant();
        public abstract void ShutdownPlant();
        public abstract void TrainWeapon();
        public abstract void FireWeapon();

        /* ********************************************************
			ToString() Method - may be overridden in subclasses.
		*********************************************************/
        public override String ToString() {
            return "Vessel name: " + _name + " | " + _plant + " | " + _weapon;
        }

    }// End Vessel 
} // End namespace
