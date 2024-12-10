using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCRUD_UsingEF
{
    public class MyDogsContext : DbContext
    {
        public DbSet<Dog> MyDogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer(@"server=DESKTOP-UUHFTEI\TEST;database=DOGSDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
