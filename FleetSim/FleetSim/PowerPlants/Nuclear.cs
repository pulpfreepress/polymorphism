using System;

namespace FleetSim.PowerPlants {

    public class Nuclear : PowerPlant {

        public Nuclear(String model) : base(model) {
            Console.WriteLine("Nuclear powerplant object created!");
        }

        public override void LightoffPlant() {
            Console.WriteLine("Nuclear reactor is critical! Ready to answer all bells!");
        }

        public override void ShutdownPlant() {
            Console.WriteLine("Nuclear plant is shut down and secured.");
        }

    } // End Nuclear
} // End namespace
