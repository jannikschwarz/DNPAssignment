using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Db
{
    public class DbUserService : IDbUserService
    {
        DataContext ctx = new DataContext();
        private List<User> users;
        public async Task<IList<User>> getUserAsync()
        {
            IList<User> users = await ctx.Users.ToListAsync();
            return users;
        }

        public async Task<User> validateUserAsync(string userName, string password)
        {
            return await ctx.Users.FirstOrDefaultAsync(u => u.userName.Equals(userName) && u.password.Equals(password));
        }

        public async Task RunDbSetupAsync()
        {
            if (ctx.Users.ToList().Count == 0)
            {
                users = new[] {
                    new User {
                        City = "Horsens",
                        Domain = "via.dk",
                        password = "123456",
                        Role = "Teacher",
                        BirthYear = 1986,
                        SecurityLevel = 5,
                        userName = "Troels"
                    },
                    new User {
                        City = "Aarhus",
                        Domain = "hotmail.com",
                        password = "123456",
                        Role = "Student",
                        BirthYear = 1998,
                        SecurityLevel = 3,
                        userName = "Jakob"
                    },
                    new User {
                        City = "Vejle",
                        Domain = "via.com",
                        password = "123456",
                        Role = "Guest",
                        BirthYear = 1973,
                        SecurityLevel = 1,
                        userName = "Kasper"
                    }
                }.ToList();
                foreach (var VARIABLE in users)
                {
                    await ctx.Users.AddAsync(VARIABLE);
                }
                await ctx.SaveChangesAsync();
            }
        }
    }
}