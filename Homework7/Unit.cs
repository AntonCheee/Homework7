using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    abstract class Unit
    {
        protected Unit(double ad, string name)
        {
            this.Ad = ad;
            this.Name = name;
        }

        public double Hp { get; set; }
        public double Ad { get; }
        public string Name { get; }
        public bool IsAlive => this.Hp > 0;
        public abstract double Attack();
        public abstract void Defense(Unit enemyUnit);
    }
}
