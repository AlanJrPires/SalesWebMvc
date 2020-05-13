using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //Verfica se o banco de dados já foi populado
            }

            Department d1 = new Department("Computers");
            Department d2 = new Department("Electronics");
            Department d3 = new Department("Fashion");
            Department d4 = new Department("Books");

            Seller s1 = new Seller("Bob Brown", "bobbrown@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller("Maria Green", "mariagreen@gmail.com", new DateTime(1978, 5, 11), 1500.0, d2);
            Seller s3 = new Seller("Alex Green", "alexgreen@gmail.com", new DateTime(1994, 4, 13), 1700.0, d3);
            Seller s4 = new Seller("Martha Brown", "marthabrown@gmail.com", new DateTime(1989, 7, 21), 1500.0, d4);
            Seller s5 = new Seller("Donald Blue", "donaldblue@gmail.com", new DateTime(1978, 4, 28), 1000.0, d1);
            Seller s6 = new Seller("Alex Pink", "alexpink@gmail.com", new DateTime(1977, 7, 21), 1500.0, d2);

            SalesRecord r1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2018, 04, 30), 14000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(new DateTime(2018, 01, 25), 17000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(new DateTime(2018, 02, 25), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(new DateTime(2018, 03, 25), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(new DateTime(2018, 07, 25), 6000.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(new DateTime(2018, 08, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(new DateTime(2018, 10, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(new DateTime(2018, 11, 25), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(new DateTime(2018, 12, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(new DateTime(2018, 09, 05), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(new DateTime(2018, 09, 15), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(new DateTime(2018, 09, 25), 14000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(new DateTime(2018, 09, 29), 17000.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(new DateTime(2018, 09, 28), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(2018, 09, 27), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(new DateTime(2018, 09, 24), 6000.0, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r22 = new SalesRecord(new DateTime(2018, 04, 15), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r24 = new SalesRecord(new DateTime(2018, 09, 25), 14000.0, SaleStatus.Billed, s2);
            SalesRecord r25 = new SalesRecord(new DateTime(2018, 09, 25), 17000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(new DateTime(2018, 09, 25), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r28 = new SalesRecord(new DateTime(2018, 09, 25), 6000.0, SaleStatus.Billed, s6);
            SalesRecord r29 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r30 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                                          r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                                          r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.SaveChanges();
        }
    }
}
