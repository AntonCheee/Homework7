using System.Linq;

namespace Homework7
{
    public class FightLogic
    {
        public static Unit FightOneOnOne(Unit unit1, Unit unit2)
        { 
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

        public static Group FightGroupByGroup(Group group1, Group group2)
        {
            while (group1.AliveFighters.Count > 0 && group2.AliveFighters.Count > 0)
            {
                Unit group1Fighter = group1.AliveFighters[Randomizer.RandomInt(0, group1.AliveFighters.Count)];
                Unit group2Fighter = group2.AliveFighters[Randomizer.RandomInt(0, group2.AliveFighters.Count)];

                SingleFight(group1Fighter, group2Fighter);
            }

            return group1.AliveFighters.Count == 0 ? group2 : group1;
        }

        public static Unit FightOneAgainstAll(Group group)
        {
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
                fighter1.AttackEnemy(fighter2);
            }
            else
            {
                fighter2.AttackEnemy(fighter1);
            }
        }
    }
}