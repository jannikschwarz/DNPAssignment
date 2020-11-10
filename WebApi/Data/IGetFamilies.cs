 using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Data{
    public interface IGetFamilies{
 Task<IList<Adult>> allAdultsAsync();
 Task addNewAdultAsync(Adult adult);
 Task RemoveAdultAsync(int adultId);
 Task UpdateAdultAsync(Adult adult);

 }
}