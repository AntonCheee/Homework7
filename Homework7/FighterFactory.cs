using System.Collections.Generic;

namespace Homework7
{
    public class FighterFactory
    {
        public static Unit CreateFighter(FighterType? fighterType = null)
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

        public static Group CreateGroup(int countFighters)
        {
            List<Unit> groupFighters = new List<Unit>();

            for (int i = 0; i < countFighters; i++)
            {
                groupFighters.Add(FighterFactory.CreateFighter());
            }

            return new Group(groupFighters);
        }
    }
}
