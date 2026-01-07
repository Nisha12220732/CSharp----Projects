using System;
namespace DigitalPettyCash
{
    public class IncomeTransaction : IReportable
    {
        public string Source { get; set; }
        public IncomeTransaction(int id,DateTime date, float Amount, string desc, string source)
        {
            Id = id;
            Date = date;
            this.Amount = Amount;
            Description = desc;
            Source = source;
        }

        public override void GetSummary()
        {
            System.Console.WriteLine("Transaction Id is {0}\n Transaction Date is {1}\n Transaction Amount is {2}\n Transaction Description is {3}\n Transaction Source is {4}\n", Id,Date,Amount,Description,Source);
        }
    }
}