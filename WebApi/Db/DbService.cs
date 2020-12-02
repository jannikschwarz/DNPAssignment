using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApi.Models;

namespace Db
{
    public class DbService : IDbService
    {
        DataContext ctx = new DataContext();
        public async Task<Adult> getAdultAsync(int id)
        {
            Adult temp = await ctx.Adults.FirstAsync(a => a.Id == id);
            return temp;
        }

        public async Task<IList<Adult>> getAllAdultAsync()
        {
            List<Adult> adults = await ctx.Adults.ToListAsync();
            return adults;
        }

        public async Task removeAdultAsync(Adult adult)
        {
            ctx.Remove(adult);
            await ctx.SaveChangesAsync();
        }

        public async Task RunDbSetup()
        {
            Adult temp = ctx.Adults.FirstOrDefault(a => a.Id == 0);
            if(temp == null){
                IList<Adult> adults = new List<Adult>();
                string context = File.ReadAllText("adults.json");
                adults = JsonSerializer.Deserialize<List<Adult>>(context);
                foreach(var adult in adults){
                    Console.WriteLine(adult.FirstName);
                    await saveAdultAsync(adult);
                }
            }
        }

        public async Task<Adult> saveAdultAsync(Adult Adult)
        {
            EntityEntry<Adult> newlyAdded;
            if (!ctx.Adults.Contains(Adult))
            {
                newlyAdded = await ctx.Adults.AddAsync(Adult);
                await ctx.SaveChangesAsync();
                return newlyAdded.Entity;
            }
            return null;
        }

        public async Task updateAdultAsync(Adult adult)
        {
            ctx.Adults.Update(adult);
            await ctx.SaveChangesAsync();
        }
    }
}