using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterialAPI.Model
{
    public class MaterialContext : DbContext
    {
        public MaterialContext(DbContextOptions<MaterialContext> options)
            : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
    }
}
