using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Bat : Animal
    {
        public int NumberOfNipples { get { return 2; } }
        
        public override string Sound()
        {
            return "Squeak, squeak!";
        }
    }
}