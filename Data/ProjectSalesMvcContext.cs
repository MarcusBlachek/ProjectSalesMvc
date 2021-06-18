using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesMvc.Models;

namespace ProjectSalesMvc.Models
{
    public class ProjectSalesMvcContext : DbContext
    {
        public ProjectSalesMvcContext (DbContextOptions<ProjectSalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
