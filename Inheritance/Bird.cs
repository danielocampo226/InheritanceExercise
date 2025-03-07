﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {
            IsAlive= true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0.1;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }    
        public bool DoMigrate { get; set; }
        public double BeakLength { get; set; }  
    }
}
