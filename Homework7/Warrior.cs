using System;

namespace Homework7
{
    class Warrior : Unit
    {
        private const double HP = 200;
        private const double AD = 20;
        private const double ATTACK_DAMAGE_PERCENT = 0.5;
        private const double DEFENCE_DAMAGE_PERCENT = 0.7;

        public Warrior():base(AD, "Warrior" + Randomizer.RandomInt(1, 1000))
        {
            this.Hp = HP;
        }

        public override double Attack()
        {
           return Math.Round(AD * ATTACK_DAMAGE_PERCENT, 2);
        }

        public override void Defense(Unit enemyUnit)
        {
            this.Hp -= Math.Round(enemyUnit.Attack() * DEFENCE_DAMAGE_PERCENT, 2);
        }
    }
}
