using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework7
{
    class Team
    {
        private string teamName;
        private List<Unit> teamFighters;

        public string TeamName { get => teamName; }
        public List<Unit> TeamFighters { get => teamFighters; }

        public Team()
        {
            teamName = "Team" + new Random().Next();
            teamFighters = new List<Unit> { FightLogic.GenerateFighter(), FightLogic.GenerateFighter(), FightLogic.GenerateFighter() };
        }

        public List<Unit> AliveFighters => this.TeamFighters.Where(x => x.IsAlive).ToList();
    }
}
