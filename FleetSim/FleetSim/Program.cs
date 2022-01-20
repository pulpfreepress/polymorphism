﻿using System;

using FleetSim.Vessels;
using FleetSim.Weapons;
using FleetSim.PowerPlants;

namespace FleetSim {

    class Program {

        public static void Main(string[] args) {

            Vessel v1 = new Submarine(new Nuclear("Preasureized Water Mk 85"),
                                      new Torpedo("MK 50"),
                                      "USS Falls Church");
            v1.LightoffPlant();
            v1.TrainWeapon();
            v1.FireWeapon();
            v1.ShutdownPlant();

        } // End Main
    } // End Program
} // End namespace
