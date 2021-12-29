using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Group
    {
        public string GroupName { get; }
        public List<Unit> GroupFighters { get; }

        public Group(List<Unit> listFighters)
        {
            GroupName = "Group" + new Random().Next();
            GroupFighters = listFighters;
        }

        public List<Unit> AliveFighters => this.GroupFighters.Where(x => x.IsAlive).ToList();
    }
}