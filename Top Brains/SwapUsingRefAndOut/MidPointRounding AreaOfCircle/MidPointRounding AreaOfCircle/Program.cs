class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of Circle: ");
        double r = Double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Round(r*r*3.14,2));
    }
}