using BlueCoding.Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCoding.Test.Context
{
    public class DataContext: DbContext
    {
        public DataContext (DbContextOptions<DataContext> options): base(options)
        {

        }
        public DbSet<Plant> Plants { get; set; }
    }
}
