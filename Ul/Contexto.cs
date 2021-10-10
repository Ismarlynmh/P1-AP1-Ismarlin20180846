using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Ismarlyn_20180846.Ul
{
    class Contexto
    {
        public class Contexto : DbContext
        {
            public DbSet<aporte> aporte { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite(@"data source = data\APORTEControl.db");
            }
        }
    }
}
