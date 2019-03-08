using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace deneme.Models
{
    public class denemeContext : DbContext
    {
        public denemeContext(DbContextOptions<denemeContext> options):base(options)
        {

        }
       public DbSet<ogrenciler> ogrenciler { get; set; }
    }
}
