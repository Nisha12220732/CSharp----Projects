class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter num1: ");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter num2: ");
        int num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter num3: ");
        int num3 = Int32.Parse(Console.ReadLine());

        if(num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"{num1} is the Largest");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"{num2} is the Largest");
        }
        else
        {
            Console.WriteLine($"{num3} is the Largest");
        }
    }
}