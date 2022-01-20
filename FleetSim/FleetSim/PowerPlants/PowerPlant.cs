using System;

namespace FleetSim.PowerPlants {

    public abstract class PowerPlant {

        private String _model = null;

        public PowerPlant(String model) {
            _model = model;
            Console.WriteLine("PowerPlant object created!");
        }

        public abstract void LightoffPlant();
        public abstract void ShutdownPlant();

        public override String ToString() { return "Power plant model: " + _model; }

    } // End PowerPlant
} // End namespace
