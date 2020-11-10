using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment.Data{
    public interface IGetFamilies{
        Task<List<Adult>> allAdultsAsync();
        Task addNewAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task UpdateAdultAsync(Adult adult);
        
}
}