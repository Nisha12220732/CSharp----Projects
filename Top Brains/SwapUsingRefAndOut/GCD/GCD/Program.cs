class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int b = Int32.Parse(Console.ReadLine());

        for(int i = Math.Min(a, b); i > 0; i--)
        {
            if(a%i == 0 && b%i == 0)
            {
                Console.WriteLine($"GCD of {a} and {b} is {i}");
                break;
            }
        }

    }
}
