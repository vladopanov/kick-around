using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public class Group : BaseEntity
    {
        public Group()
        {
            this.Matches = new List<Match>();
        }

        public string Name { get; set; }

        public string AdminId { get; set; }

        public List<Match> Matches { get; set; }

        public List<PlayerGroup> PlayerGroups { get; set; }
    }
}
