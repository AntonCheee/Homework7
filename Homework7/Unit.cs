using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; }
        public bool IsAlive => this.Hp > 0;

        public abstract double Attack();
        public abstract void Defense(Unit enemyUnit);
    }
}
