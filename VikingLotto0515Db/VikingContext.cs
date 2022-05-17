using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingLotto0515Db
{
    public class VikingContext : DbContext
    {
        public DbSet<Huzas> Huzasok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;DataBase=VikingLottoDb0515;Trusted_Connection=true");
        }
    }
}
