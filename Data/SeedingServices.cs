using ProjectSalesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSalesMvc.Models.Enums;

namespace ProjectSalesMvc.Data
{
    public class SeedingServices
    {
        private ProjectSalesMvcContext _context;

        public SeedingServices(ProjectSalesMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            

            Department d1 = new Department("Eletrônicos");
            Department d2 = new Department("Moda");
            Department d3 = new Department("Livros");

            Seller s1 = new Seller("Marcus Blachek","marcus_blachek@hotmail.com",new DateTime(1984-06-11),2000.0,d1);
            Seller s2 = new Seller("Tatiana Borba","tatifono@uol.com.br",new DateTime(1980 - 05 - 21),2000.0, d2);
            Seller s3 = new Seller("Marcela Blachek","marcela_blachek@hotmail.com",new DateTime(1990 - 07 - 09),2000.0, d3);

            SalesRecord sr1 = new SalesRecord(new DateTime(2021,06,11),200.00,SalesStatus.Billed,s1);
            SalesRecord sr2 = new SalesRecord(new DateTime(2021,06,11),200.00,SalesStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(new DateTime(2021,06,11),300.00,SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(new DateTime(2021,06,11),550.00,SalesStatus.Canceled, s3);
            SalesRecord sr5 = new SalesRecord(new DateTime(2021,06,11),100.50,SalesStatus.Billed, s3);
            SalesRecord sr6 = new SalesRecord(new DateTime(2021,06,12),900.2,SalesStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(new DateTime(2021,06,12),1080.6,SalesStatus.Billed, s1);
            SalesRecord sr8 = new SalesRecord(new DateTime(2021,06,12),250.60,SalesStatus.Pending, s2);
            SalesRecord sr9 = new SalesRecord(new DateTime(2021,06,12),390.80,SalesStatus.Billed, s3);
            SalesRecord sr10 = new SalesRecord(new DateTime(2021,06,12),465.90,SalesStatus.Billed, s3);

            _context.Department.AddRange(d1,d2,d3);
            _context.Seller.AddRange(s1,s2,s3);
            _context.SalesRecord.AddRange(sr1,sr2,sr3,sr4,sr5,sr6,sr7,sr8,sr9,sr10);


            _context.SaveChanges();

        }
    }
}
