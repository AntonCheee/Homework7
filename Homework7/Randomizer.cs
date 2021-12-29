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

        public static (Unit, Unit) RandomUniqPairFighters(Group group)
        {
            int fighter1Index = RandomInt(0, group.AliveFighters.Count);
            int fighter2Index = fighter1Index;

            while (fighter1Index == fighter2Index)
            {
                fighter2Index = RandomInt(0, group.AliveFighters.Count);
            }

            return (group.AliveFighters[fighter1Index], group.AliveFighters[fighter2Index]);
        }

        public static bool IsSuccessAction(double chance)
        {
            return new Random().NextDouble() <= chance;
        }
    }
}