using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public List<PlayerGroup> PlayerGroups { get; set; }

        public List<AttendeeMatch> AttendeeMatches { get; set; }
    }
}
