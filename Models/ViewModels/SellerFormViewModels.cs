
using System.Collections.Generic;


namespace ProjectSalesMvc.Models.ViewModels
{
    public class SellerFormViewModels
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
