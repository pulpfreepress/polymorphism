using System;

namespace FleetSim.PowerPlants {

    public class Steam : PowerPlant {

        public Steam(String model) : base(model) {
            Console.WriteLine("Steam plant object created!");
        }

        public override void LightoffPlant() {
            Console.WriteLine("Steam pressure is rising! Ready to answer all bells!");
        }

        public override void ShutdownPlant() {
            Console.WriteLine("Steam plant is secure!");
        }

    } // End Steam
} // End namespace
