using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx
{
    namespace Support
    {
        // Random without create object
        // StaticRandom.Rand.Next(min,max)
        public static class StaticRandom
        {
            public static Random Rand { private set; get; } = new Random();

            public static void Randomize()
            {
                Rand = new Random();
            }
        }
    }
}
