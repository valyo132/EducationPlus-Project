using EducationPLus.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EducationPLus
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Order> Oreders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer("Server=.;Database=EducationPlusProject;Trusted_Connection=True;");
            }
            else
            {
                base.OnConfiguring(dbContextOptionsBuilder);
            }
        }
    }
}
