using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public class Match : BaseEntity
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsWeekly { get; set; }

        public Group Group { get; set; }

        public List<AttendeeMatch> AttendeeMatches { get; set; }
    }
}
