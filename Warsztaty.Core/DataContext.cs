using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Warsztaty.Core
{
    public class DataContext: DbContext
    {
        public virtual DbSet<ContactModel> Contact { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:warsztatyunit44.database.windows.net,1433;Initial Catalog=warsztatyunit44;Persist Security Info=False;User ID=Mrijv;Password=Durabrite95;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
