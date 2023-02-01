using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public Animal()
        {

        }

        public bool IsAlive { get; set; }
        public double Age { get; set; }

        public int LegCount { get; set; }
        public string LandSeaAir { get; set; }
    }
}
