using System;

namespace Homework7
{
    class Program
    {
        static void Main()
        {

            Unit unit1 = FighterFactory.CreateFighter(FighterType.Archer);
            Unit unit2 = FighterFactory.CreateFighter();
            Unit winner = FightLogic.FightOneOnOne(unit1, unit2);



            //int countFightersPerGroup = 10;
            //Group group1 = FighterFactory.CreateGroup(countFightersPerGroup);
            //Group group2 = FighterFactory.CreateGroup(countFightersPerGroup);
            //Group winner = FightLogic.FightGroupByGroup(group1, group2);



            //Group group = FighterFactory.CreateGroup(5);
            //Unit winner = FightLogic.FightOneAgainstAll(group);
            //Console.WriteLine($"Winner {winner.GetType()}, HP={winner.Hp}");
        }
    }
}
