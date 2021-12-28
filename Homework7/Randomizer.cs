using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Randomizer
    {
        private static readonly Random random = new Random();
        public static bool RandomBool()
        {
            return random.NextDouble() < 0.5;
        }

        public static int RandomInt(int from, int to)
        {
            return random.Next(from, to);
        }
    }
}