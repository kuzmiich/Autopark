﻿using System;
using System.Collections.Generic;

namespace Autopark.Entity.Const
{
    public struct VehicleBrand
    {
        public const string Lamborghini = "Lamborghini";
        public const string Lada = "Lada";
        public static List<string> CarBrand => new()
        {
            Lada,
            Lamborghini
        };

        public const string Zil = "Zil";

        public static List<string> TruckBrand => new() 
        { 
            Zil
        };
    }
}
