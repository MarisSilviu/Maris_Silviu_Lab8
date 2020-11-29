using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maris_Silviu_Lab8.Models;

namespace Maris_Silviu_Lab8.Data
{
    public class Maris_Silviu_Lab8Context : DbContext
    {
        public Maris_Silviu_Lab8Context (DbContextOptions<Maris_Silviu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Maris_Silviu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Maris_Silviu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Maris_Silviu_Lab8.Models.Category> Category { get; set; }
    }
}
