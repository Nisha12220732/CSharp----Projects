using System;
using Microsoft.VisualBasic;
namespace DigitalPettyCash
{
    abstract class Transaction : IReportable
    {
        public int Id {get;set;}
        public DateAndTime Date { get; set; }
        public float  Amount { get; set; }
        public string Description { get; set; }

        public Transaction(int id, DateAndTime date, float Amount, string desc)
        {
            Id = id;
            Date = date;
            this.Amount = Amount;
            Description = desc;
        }

        public abstract void GetSummary();
    }
}