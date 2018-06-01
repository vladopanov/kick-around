using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public class AttendeeMatch
    {
        public string AttendeeId { get; set; }

        public User Attendee { get; set; }

        public string MatchId { get; set; }

        public Match Match { get; set; }
    }
}
