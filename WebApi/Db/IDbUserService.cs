using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Db
{
    public interface IDbUserService
    {
        Task<IList<User>> getUserAsync();
        Task<User> validateUserAsync(string username, string password);
        Task RunDbSetupAsync();
    }
}