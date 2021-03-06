﻿using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Factories
{
   public static class VehicleFactory
    {
            public static Vehicle CreateVehicle(string type)
            {
                Vehicle vehicle;
                switch (type)
                {
                    case "Semi":
                        vehicle = new Semi();
                        break;
                    case "Truck":
                        vehicle = new Truck();
                        break;
                    case "Van":
                        vehicle = new Van();
                        break;
                    default:
                        throw new InvalidOperationException("Invalid vehicle type!");
                }
                return vehicle;
            }
        }
    }
