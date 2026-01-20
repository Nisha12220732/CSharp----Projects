class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the height (in cm)");
        int height = Int32.Parse(Console.ReadLine());
        if (height < 150)
        {
            Console.WriteLine("Short");
        }
        else if(height < 180 &&  height >= 150)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Tall");
        }
    }
}