using Microsoft.EntityFrameworkCore;

namespace jmWebApi.data
{

    public class jsonstring{
        string jstr { get;set; }
    }

    public class jContext : DbContext
    {
        public DbSet<vendor> vendors { get; set; }
        public DbSet<jsonstring> jstring { get; set; }
        public jContext(DbContextOptions<jContext> options)
            : base(options)
        { }
    }    
}