using KickAround.Data;
using KickAround.Models.EntityModels;
using KickAround.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickAround.Services
{
    public class UserService : IUserService
    {
        private readonly KickAroundContext context;

        public UserService(KickAroundContext context)
        {
            this.context = context;
        }

        public Task<bool> ValidateCredentials(string userName, string password, out User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this.context.Users.ToList();
        }
    }
}
