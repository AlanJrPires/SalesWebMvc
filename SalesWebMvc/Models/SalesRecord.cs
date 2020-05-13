using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Saller { get; set; }

        public SalesRecord()
        {
        }
        public SalesRecord(DateTime date, double amount, SaleStatus status, Seller saller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Saller = saller;
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller saller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Saller = saller;
        }
    }
}
