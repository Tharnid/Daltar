using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public ClassName(Parameters)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}
