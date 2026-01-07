using System;
using System.Collections.Generic;
using System.Transactions;

public class Ledger<T> where T : Transaction
{
    List<T> transactions = new List<T>();

    public void AddEntry(T trans1)
    {
        transactions.Add(trans1);
    }

    public List<Transaction> GetTransactionsByDate(DateTime date)
    {
        List<Transaction> ansList = new List<Transaction>();
        foreach(Trans t in transactions)
        {
            if(Trans.Date == date)
            {
                ansList.Add(Trans);
            }
        }
        return ansList;
    }

    public double CalculateTotalTransactions()
    {
        double Total = 0;
        foreach(Trans t in transactions)
        {
            Total += Trans.Amount;
        }
        return Total;
    }
}
