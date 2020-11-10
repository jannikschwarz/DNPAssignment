using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Models;


namespace Assignment.Data{
    public class GetFamilies: IGetFamilies{

    private string uri = "https://localhost:5003";
    
    private readonly HttpClient client;

    public GetFamilies(){
        client = new HttpClient();
    }

    public async Task<List<Adult>> allAdultsAsync(){
        Task<string> stringAsync = client.GetStringAsync(uri+"/Adults");
        string message = await stringAsync;
        List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(message);
        return adults;
    }
    public async Task addNewAdultAsync(Adult newAdult){
            string todoAsJson = JsonSerializer.Serialize(newAdult);
            HttpContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync(uri+"/Adults", content);
        
    }

    public async Task RemoveAdultAsync(int adultId){
        await client.DeleteAsync($"{uri}/Adults/{adultId}");
    }

    public async Task UpdateAdultAsync(Adult adult){
        string todoAsJson = JsonSerializer.Serialize(adult);
        HttpContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
        await client.PatchAsync($"{uri}/Adults/{adult.Id}", content);
    }
}
}
