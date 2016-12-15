using Microsoft.EntityFrameworkCore;

namespace jmWebApi.data
{
    public class jContext : DbContext
    {
        public DbSet<vendor> vendors { get; set; }
        public jContext(DbContextOptions<jContext> options)
            : base(options)
        { }
    }    
}