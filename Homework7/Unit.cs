﻿
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
        public void Attack(Unit unit)
        {
            double currentDamage = Attack();
            double realDamage = unit.Defense(currentDamage);
            unit.Hp -= realDamage;
        }
    }
}
