using System;

namespace Homework7
{
    public class Wizard : Unit
    {
        private const double HP = 150;
        private const double AD = 50;
        private const double ATTACK_DAMAGE_PERCENT = 0.32;

        private const double DODGE_ATTACK_CHANCE = 0.5;
        private const double UNSUCCESS_DODGE_CHANCE = 1.1;

        public Wizard() : base(AD, HP)
        {
        }

        protected override double Attack()
        {
            double attackDamage = 0;

            if (Randomizer.IsSuccessAction(ATTACK_DAMAGE_PERCENT))
            {
                attackDamage = AD;
            }
            else if (Randomizer.IsSuccessAction(ATTACK_DAMAGE_PERCENT))
            {
                attackDamage = AD;
            }

            return attackDamage;
        }

        protected override double Defense(double damage)
        {
            if (Randomizer.IsSuccessAction(DODGE_ATTACK_CHANCE))
            {
                return Math.Round(damage * UNSUCCESS_DODGE_CHANCE, 2);
            }

            return 0;
        }
    }
}