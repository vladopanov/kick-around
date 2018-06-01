using KickAround.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KickAround.Services.Contracts
{
    public interface IUserService
    {
        Task<bool> ValidateCredentials(string userName, string password, out User user);
        IEnumerable<User> GetAllUsers();
    }
}
