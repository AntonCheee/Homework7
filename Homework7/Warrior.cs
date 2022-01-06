using System;

namespace Homework7
{
    public class Warrior : Unit
    {
        private const double HP = 200;
        private const double AD = 35;
        private const double ATTACK_DAMAGE_PERCENT = 0.71;
        private const double DEFENCE_DAMAGE_PERCENT = 0.5;

        public Warrior() : base(AD, HP)
        {
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
