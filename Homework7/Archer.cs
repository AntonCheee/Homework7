using System;

namespace Homework7
{
    class Archer : Unit
    {
        private const double HP = 120;
        private const double AD = 35;

        private const double DODGE_ATTACK_CHANCE = 0.5;
        private const double UNSUCCESS_DODGE_CHANCE = 1.2;

        private const double CRITICAL_ATTACK_CHANCE = 0.33;
        private const double CRITICAL_DAMAGE_CHANCE = 2;

        public Archer():base(AD, "Archer" + Randomizer.RandomInt(1, 1000))
        {
            this.Hp = HP;
        }

        public override double Attack()
        {
            double attackDemage = AD;

            if (Randomizer.IsSuccessAction(CRITICAL_ATTACK_CHANCE))
            {
                attackDemage *= CRITICAL_DAMAGE_CHANCE;
            }

            return attackDemage;
        }

        public override void Defense(Unit enemyUnit)
        {
            if (!Randomizer.IsSuccessAction(DODGE_ATTACK_CHANCE))
            {
                this.Hp -= Math.Round(enemyUnit.Attack() * UNSUCCESS_DODGE_CHANCE, 2);
            }
        }
    }
}