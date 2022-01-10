using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    public class Group
    {
        public List<Unit> GroupFighters { get; }

        public Group(List<Unit> listFighters)
        {
            GroupFighters = listFighters;
        }

        public List<Unit> AliveFighters => this.GroupFighters.Where(x => x.IsAlive).ToList();
    }
}