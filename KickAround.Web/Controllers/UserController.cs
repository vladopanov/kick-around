using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KickAround.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KickAround.Web.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("[action]")]
        public IActionResult All()
        {
            var users = this.userService.GetAllUsers();
            if (!users.Any())
            {
                return new NoContentResult();
            }

            return new ObjectResult(users);
        }
    }
}