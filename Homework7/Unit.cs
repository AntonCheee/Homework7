
using System;

namespace Homework7
{
    public abstract class Unit
    {
        protected Unit(double ad, double hp)
        {
            this.Hp = hp;
            this.Ad = ad;
        }

        public double Ad { get; }
        public double Hp { get; private set; }
        public bool IsAlive => this.Hp > 0;

        protected abstract double Attack();
        protected abstract double Defense(double enemyUnit);
        public void AttackEnemy(Unit enemyUnit)
        {
            double currentDamage = Attack();
            double realDamage = enemyUnit.Defense(currentDamage);
            enemyUnit.Hp = Math.Round(enemyUnit.Hp - realDamage, 2);
        }
    }
}
