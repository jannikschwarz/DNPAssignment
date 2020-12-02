using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Db;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase {
        private readonly IDbUserService service;
        private IList<User> currentUsers;
        
        public UsersController(IDbUserService service) {
            this.service = service;
            service.RunDbSetupAsync();
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery]string username, [FromQuery]string password) {
            try
            {
                Console.WriteLine(username + password);
                var user = await service.validateUserAsync(username, password);
                Console.WriteLine(user.ToString());
                return Ok(user);
            } catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}