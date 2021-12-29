using System;

namespace Homework7
{
    class Program
    {
        static void Main()
        {
            //Unit winner = FightLogic.FightTwoFighters();
            //Console.WriteLine($"Winner {winner.Name}, HP = {winner.Hp}");

            Group winner = FightLogic.FightGroupByGroup(3);
            Console.WriteLine($"Winner {winner.GroupName}");

            //for (int i = 0, j = 1; i < winner.GroupFighters.Count; i++)
            //{
            //    Console.WriteLine($"Fighter №{j++}: {winner.GroupFighters[i].Name}, Alive = {winner.GroupFighters[i].IsAlive}, HP = {winner.GroupFighters[i].Hp}");
            //}

            Unit winner = FightLogic.FightOneAgainstAll(20);
            Console.WriteLine($"Winner {winner.Name}, HP={winner.Hp}");
        }
    }
}
