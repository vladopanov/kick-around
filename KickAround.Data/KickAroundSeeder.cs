using KickAround.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KickAround.Data
{
    public class KickAroundSeeder
    {
        private readonly KickAroundContext ctx;

        public KickAroundSeeder(KickAroundContext ctx)
        {
            this.ctx = ctx;
        }

        public void Seed()
        {
            this.ctx.Database.EnsureCreated();

            if (!this.ctx.Users.Any())
            {
                var user = new User() { UserName = "Pesho" };
                var user2 = new User() { UserName = "Ivan" };

                var match = new Match()
                {
                    StartDate = new DateTime(2018, 6, 15, 19, 0, 0),
                    EndDate = new DateTime(2018, 6, 15, 20, 30, 0),
                    IsWeekly = true
                };

                var group = new Group()
                {
                    Name = "Telenor",
                    AdminId = user.Id,
                    Matches = new List<Match>() { match }
                };

                var playerGroup = new PlayerGroup() { Player = user, Group = group };
                var playerGroup2 = new PlayerGroup() { Player = user2, Group = group };

                var attendeeMatch = new AttendeeMatch() { Attendee = user, Match = match };
                var attendeeMatch2 = new AttendeeMatch() { Attendee = user2, Match = match };

                this.ctx.Users.Add(user);
                this.ctx.Users.Add(user2);
                this.ctx.Matches.Add(match);
                this.ctx.Groups.Add(group);
                this.ctx.SaveChanges();
            }
        }
    }
}
