using System;

namespace Homework7
{
    class Program
    {
        static void Main()
        {
            //Unit winner = FightLogic.FightTwoFighters();
            //Console.WriteLine($"Winner {winner.Name}, HP = {winner.Hp}");

            Team winner = FightLogic.FightTeamByTeam();
            Console.WriteLine($"Winner {winner.TeamName}");

            for (int i = 0, j = 1; i < winner.TeamFighters.Count; i++)
            {
                Console.WriteLine($"Fighter №{j++}: {winner.TeamFighters[i].Name}, Alive = {winner.TeamFighters[i].IsAlive}, HP = {winner.TeamFighters[i].Hp}");
            }
        }
    }
}
