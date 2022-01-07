using System;

namespace Homework7
{
    public class Archer : Unit
    {
        private const double HP = 120;
        private const double AD = 35;

        private const double DODGE_ATTACK_CHANCE = 0.5;
        private const double UNSUCCESS_DODGE_DAMAGE = 1.2;

        private const double CRITICAL_ATTACK_CHANCE = 0.33;
        private const double CRITICAL_DAMAGE_CHANCE = 2;

        public Archer() : base(AD, HP)
        {
        }

        protected override double Attack()
        {
            double attackDemage = AD;

            if (Randomizer.IsSuccessAction(CRITICAL_ATTACK_CHANCE))
            {
                Math.Round(attackDemage *= CRITICAL_DAMAGE_CHANCE);
            }

            return attackDemage;
        }

        protected override double Defense(double damage)
        {
            if (!Randomizer.IsSuccessAction(DODGE_ATTACK_CHANCE))
            {
                return Math.Round(damage * UNSUCCESS_DODGE_DAMAGE, 2);
            }

            return 0;
        }
    }
}