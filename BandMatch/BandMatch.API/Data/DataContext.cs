using BandMatch.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BandMatch.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set;}
    }
}