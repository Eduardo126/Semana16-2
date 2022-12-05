using Microsoft.EntityFrameworkCore;
using semana16_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana16_1.Data
{
    public class semana16_1Context : DbContext
    {
        public semana16_1Context(DbContextOptions<semana16_1Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }

    }
}
