using System;
using System.ComponentModel;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Runtime;
namespace DigitalPettyCash
{
    public class ExpenseTransaction : IReportable
    {
        public string Category { get; set; }

        public ExpenseTransaction(int id,DateTime date, float Amount, string desc, string cat)
        {
            Id = id;
            Date = date;
            this.Amount = Amount;
            Description = desc;
            Category = cat;
        }

        public override void GetSummary()
        {
            System.Console.WriteLine("Transaction Id is {0}\n Transaction Date is {1}\n Transaction Amount is {2}\n Transaction Description is {3}\n Transaction Category is {4}\n", Id,Date,Amount,Description,Category);
        }

    }
}