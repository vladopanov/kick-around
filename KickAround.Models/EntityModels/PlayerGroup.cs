using System;
using System.Collections.Generic;
using System.Text;

namespace KickAround.Models.EntityModels
{
    public class PlayerGroup
    {
        public string PlayerId { get; set; }

        public User Player { get; set; }

        public string GroupId { get; set; }

        public Group Group { get; set; }
    }
}
