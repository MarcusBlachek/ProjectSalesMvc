using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectSalesMvc.Models;

namespace ProjectSalesMvc.Data
{
    public class ProjectSalesMvcContext : DbContext
    {
        public ProjectSalesMvcContext (DbContextOptions<ProjectSalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectSalesMvc.Models.Department> Department { get; set; }
    }
}
