using System;

namespace Homework7
{
    class FightLogic
    {
        public static Unit GenerateFighter()
        {
            Unit unit = Randomizer.RandomBool() ? new Warrior() : new Archer();

            return unit;
        }

        public static Unit FightTwoFighters()
        {
            Unit unit1 = GenerateFighter();
            Unit unit2 = GenerateFighter();

            Unit winner = null;

            while (true)
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
                    break;
                }


                if (!unit2.IsAlive)
                {
                    winner = unit1;
                    break;
                }
            }

            return winner;
        }

        public static Team FightTeamByTeam()
        {
            Team team1 = new Team();
            Team team2 = new Team();

            while (team1.AliveFighters.Count > 0 && team2.AliveFighters.Count > 0)
            {
                Unit team1Fighter = team1.AliveFighters[Randomizer.RandomInt(0, team1.AliveFighters.Count - 1)];
                Unit team2Fighter = team2.AliveFighters[Randomizer.RandomInt(0, team2.AliveFighters.Count - 1)];

                if (Randomizer.RandomBool())
                {
                    team1Fighter.Defense(team2Fighter);
                }
                else
                {
                    team2Fighter.Defense(team1Fighter);
                }
            }

            return team1.AliveFighters.Count == 0 ? team2 : team1;
        }
    }
}