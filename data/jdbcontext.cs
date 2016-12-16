using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace jmWebApi.data
{

    public class jsonstring{
        [Key]
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