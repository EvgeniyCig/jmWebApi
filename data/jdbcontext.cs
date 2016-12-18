using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace jmWebApi.data
{

    public class jContext : DbContext
    {
        public DbSet<equipment_vendor> equipment_vendors { get; set; }
        public jContext(DbContextOptions<jContext> options)
            : base(options)
        { }
    }    
}