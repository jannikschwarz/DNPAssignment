using Microsoft.EntityFrameworkCore;
using Models;
using WebApi.Models;

namespace Db
{
    public class DataContext : DbContext{
        public DbSet<Adult> Adults {get; set;}
        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //Datebase Name
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\Janni\OneDrive\Skrivebord\DNPExercises\Assignments\DNPAdultAssignment-master\DNPAssignment\WebApi\Adult.db");
        }
    }
}