using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace Db
{
    public interface IDbService{
        Task RunDbSetup();
        Task<Adult> getAdultAsync(int id);
        Task<IList<Adult>> getAllAdultAsync();
        Task<Adult> saveAdultAsync(Adult Adult);

        Task removeAdultAsync(Adult adult);

        Task updateAdultAsync(Adult adult);
    }
}