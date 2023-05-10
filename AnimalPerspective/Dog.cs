using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get { return 8; } }
        
        public override string Sound()
        {
            return "Woof!";
        }
    }
}