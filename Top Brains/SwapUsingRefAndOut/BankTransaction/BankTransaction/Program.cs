using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Initial Balance");
        double balance = Double.Parse(Console.ReadLine());
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Enter the Transaction Amount: ");
            double transaciton = Double.Parse(Console.ReadLine());
            if (transaciton < balance)
            {
                balance -= transaciton;
            }
            else
            {
                Console.WriteLine("Transaction Amount Exceeded Balance!!");
                Console.WriteLine("Transaction Halt!!");
                exit = true;
                break;
            }
            Console.WriteLine($"Current Balance is {balance}");
            Console.WriteLine("Do you want to exit (true/false)");
            bool flag = bool.Parse(Console.ReadLine());
            if (flag)
            {
                exit = true;
            }
            Console.WriteLine($"Final balance is {balance}");

        }
    }
}
