using ProjectSalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSalesMvc.Services
{
    public class SellerService
    {
        private readonly ProjectSalesMvcContext _context;

        public SellerService(ProjectSalesMvcContext context )
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
