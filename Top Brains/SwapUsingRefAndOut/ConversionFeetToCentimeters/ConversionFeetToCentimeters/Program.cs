class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your Choice: ");
        Console.WriteLine("1. Convert Foot to Centimeters");
        Console.WriteLine("2. Convert Centimeters to Foot");
        int choice = Int32.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.WriteLine("Measunrements in Foot");
                    double foot = float.Parse(Console.ReadLine());
                    double cm = Math.Round(foot * 30.48, 2);
                    Console.WriteLine($"Measurement in Centimeters is: {cm}");
                    break;
                }

            case 2:
                {
                    Console.WriteLine("Measunrements in Centimeters");
                    double cm = float.Parse(Console.ReadLine());
                    double foot = Math.Round(cm / 30.48, 2);
                    Console.WriteLine($"Measurement in Centimeters is: {foot}");
                    break;

                }
            default :
                Console.WriteLine("Entered a Wrong Choice");
                break;

        }
        


    }
}