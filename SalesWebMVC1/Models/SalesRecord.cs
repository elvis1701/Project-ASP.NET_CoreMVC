using SalesWebMVC1.Models.Enums;
using System;


namespace SalesWebMVC1.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int iD, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            ID = iD;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
