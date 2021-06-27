using Microsoft.EntityFrameworkCore;
using ProjectSalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSalesMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjectSalesMvcContext _context;

        public DepartmentService(ProjectSalesMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
