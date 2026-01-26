class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the No. of Elements in array");
        int n = Int32.Parse(Console.ReadLine());
        double?[] arr = new double?[n];

        Console.WriteLine("Enter Array Elements: ");
        for(int i = 0; i < n; i++)
        {
            if (Double.TryParse(Console.ReadLine(), out double value))
            {
                arr[i] = value;
            }
            else
            {
                arr[i] = null; // invalid input handled
            }
        }

        double avg = 0;
        for(int i = 0; i < n; i++)
        {
            if (arr[i].HasValue)
            {
                avg += arr[i].Value;
            }
        }

        Console.WriteLine(Math.Round(avg/n,2));
    }
}
