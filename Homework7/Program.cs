using System;

namespace Homework7
{
    class Program
    {
        static void Main()
        {
            Unit winner;
            int warriorWins = 0;
            int archerWins = 0;
            int wizardWins = 0;

            for (int i = 0; i < 1000; i++)
            {
                winner = FightLogic.FightOneOnOne(FighterType.Archer, FighterType.Wizard);
                if (winner is Warrior)
                {
                    ++warriorWins;
                }
                if (winner is Archer)
                {
                    ++archerWins;
                }
                if (winner is Wizard)
                {
                    ++wizardWins;
                }
            }

            Console.WriteLine("Warrior wins = " + warriorWins);
            Console.WriteLine("Archer wins = " + archerWins);
            Console.WriteLine("Wizard wins = " + wizardWins);

            //Group winner = FightLogic.FightGroupByGroup(3);
            //Console.WriteLine($"Winner {winner.GroupName}");

            //for (int i = 0, j = 1; i < winner.GroupFighters.Count; i++)
            //{
            //    Console.WriteLine($"Fighter №{j++}: {winner.GroupFighters[i].Name}, Alive = {winner.GroupFighters[i].IsAlive}, HP = {winner.GroupFighters[i].Hp}");
            //}

            //Unit winner = FightLogic.FightOneAgainstAll(20);
            //Console.WriteLine($"Winner {winner.Name}, HP={winner.Hp}");
        }
    }
}
