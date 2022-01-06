using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    public class FightLogic
    {
        static Unit GenerateFighter(FighterType? fighterType = null)
        {
            Unit unit;

            if (fighterType is null)
            {
                int randomIndex = Randomizer.RandomInt(0, 3);

                switch (randomIndex)
                {
                    case 0:
                        unit = new Warrior();
                        break;
                    case 1:
                        unit = new Archer();
                        break;
                    default:
                        unit = new Wizard();
                        break;
                }
            }
            else
            {
                switch (fighterType)
                {
                    case FighterType.Warrior:
                        unit = new Warrior();
                        break;

                    case FighterType.Archer:
                        unit = new Archer();
                        break;

                    default:
                        unit = new Wizard();
                        break;
                }
            }

            return unit;
        }

        static Unit FightOneOnOne(FighterType? fighter1Type = null, FighterType? fighter2Type = null)
        {
            Unit unit1 = fighter1Type != null ? GenerateFighter(fighter1Type) : GenerateFighter();
            Unit unit2 = fighter2Type != null ? GenerateFighter(fighter2Type) : GenerateFighter();

            Unit winner = unit1;

            while (unit1.IsAlive && unit2.IsAlive)
            {
                if (Randomizer.RandomBool())
                {
                    unit1.Defense(unit2);
                }
                else
                {
                    unit2.Defense(unit1);
                }

                if (!unit1.IsAlive)
                {
                    winner = unit2;
                }
            }

            return winner;
        }

        static Group FightGroupByGroup(int countFightersPerGroup)
        {
            List<Unit> group1Fighters = new List<Unit>();

            for (int i = 0; i < countFightersPerGroup; i++)
            {
                group1Fighters.Add(GenerateFighter());
            }

            List<Unit> group2Fighters = new List<Unit>();

            for (int i = 0; i < countFightersPerGroup; i++)
            {
                group2Fighters.Add(GenerateFighter());
            }

            Group group1 = new Group(group1Fighters);
            Group group2 = new Group(group2Fighters);

            while (group1.AliveFighters.Count > 0 && group2.AliveFighters.Count > 0)
            {
                Unit group1Fighter = group1.AliveFighters[Randomizer.RandomInt(0, group1.AliveFighters.Count)];
                Unit group2Fighter = group2.AliveFighters[Randomizer.RandomInt(0, group2.AliveFighters.Count)];

                if (Randomizer.RandomBool())
                {
                    group1Fighter.Defense(group2Fighter);
                }
                else
                {
                    group2Fighter.Defense(group1Fighter);
                }
            }

            return group1.AliveFighters.Count == 0 ? group2 : group1;
        }

        public static Unit FightOneAgainstAll(int countFighters)
        {
            List<Unit> fighters = new List<Unit>();

            for (int i = 0; i < countFighters; i++)
            {
                fighters.Add(FightLogic.GenerateFighter());
            }

            Group group = new Group(fighters);

            while (group.AliveFighters.Count > 1)
            {
                (Unit fighter1, Unit fighter2) pairFighters = Randomizer.RandomUniqPairFighters(group);

                if (Randomizer.RandomBool())
                {
                    pairFighters.fighter1.Defense(pairFighters.fighter2);
                }
                else
                {
                    pairFighters.fighter2.Defense(pairFighters.fighter1);
                }
            }

            return group.AliveFighters.Single();
        }
    }
}