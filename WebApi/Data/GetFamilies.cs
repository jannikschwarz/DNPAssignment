using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Models;


namespace WebApi.Data{
    public class GetFamilies: IGetFamilies{

    private string adultFile = "adults.json";
    private IList<Adult> adults;

    public GetFamilies() {
        if (!File.Exists(adultFile)) {
            WriteFamilyToFile();
        } else {
            string content = File.ReadAllText(adultFile);
            adults = JsonSerializer.Deserialize<List<Adult>>(content);
        }
    }
    public async Task<IList<Adult>> allAdultsAsync(){
        List<Adult> tmp = new List<Adult>(adults);
        return tmp;
    }

    public async Task addNewAdultAsync(Adult newAdult){
        adults.Add(newAdult);
        WriteFamilyToFile();
    }

    public async Task RemoveAdultAsync(int adultId){
        Adult toRemove = adults.First(t => t.Id == adultId);
        adults.Remove(toRemove);
        WriteFamilyToFile();
    }

    public async Task UpdateAdultAsync(Adult adult){
        await RemoveAdultAsync(adult.Id);
        await addNewAdultAsync(adult);
        WriteFamilyToFile();
    }

    private void WriteFamilyToFile() {
        string productsAsJson = JsonSerializer.Serialize(adults);
        File.WriteAllText(adultFile, productsAsJson);
    }

}
}
