using System;

namespace FleetSim.PowerPlants {

    public class GasTurbine : PowerPlant {

        public GasTurbine(String model) : base(model) {
            Console.WriteLine("Gas Turbine powerplant object created!");
        }

        public override void LightoffPlant() {
            Console.WriteLine("Gas Turbine powerplant is online and ready to answer all bells!");
        }

        public override void ShutdownPlant() {
            Console.WriteLine("Gas Turbine is shutdown and secured!");
        }

    } // End GasTurbine
} // End namespace
