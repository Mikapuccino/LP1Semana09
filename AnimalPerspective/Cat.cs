using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalPerspective
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get { return 6; } }
        
        public override string Sound()
        {
            return "Miau";
        }
    }
}