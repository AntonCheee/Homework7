using System.Linq;

namespace Homework7
{
    public class FightLogic
    {
        public static Unit FightOneOnOne(FighterType? fighter1Type = null, FighterType? fighter2Type = null)
        {
            Unit unit1 = fighter1Type != null ? Fighter.CreateFighter(fighter1Type) : Fighter.CreateFighter();
            Unit unit2 = fighter2Type != null ? Fighter.CreateFighter(fighter2Type) : Fighter.CreateFighter();

            Unit winner = unit1;

            while (unit1.IsAlive && unit2.IsAlive)
            {
                SingleFight(unit1, unit2);

                if (!unit1.IsAlive)
                {
                    winner = unit2;
                }
            }

            return winner;
        }

        static Group FightGroupByGroup(int countFightersPerGroup)
        {
            Group group1 = Fighter.CreateGroup(countFightersPerGroup);
            Group group2 = Fighter.CreateGroup(countFightersPerGroup);

            while (group1.AliveFighters.Count > 0 && group2.AliveFighters.Count > 0)
            {
                Unit group1Fighter = group1.AliveFighters[Randomizer.RandomInt(0, group1.AliveFighters.Count)];
                Unit group2Fighter = group2.AliveFighters[Randomizer.RandomInt(0, group2.AliveFighters.Count)];

                SingleFight(group1Fighter, group2Fighter);
            }

            return group1.AliveFighters.Count == 0 ? group2 : group1;
        }

        public static Unit FightOneAgainstAll(int countFighters)
        {
            Group group = Fighter.CreateGroup(countFighters);

            while (group.AliveFighters.Count > 1)
            {
                (Unit fighter1, Unit fighter2) pairFighters = Randomizer.RandomUniqPairFighters(group);

                SingleFight(pairFighters.fighter1, pairFighters.fighter2);
            }

            return group.AliveFighters.Single();
        }

        public static void SingleFight(Unit fighter1, Unit fighter2)
        {
            if (Randomizer.RandomBool())
            {
                fighter1.Attack(fighter2);
            }
            else
            {
                fighter2.Attack(fighter1);
            }
        }
    }
}