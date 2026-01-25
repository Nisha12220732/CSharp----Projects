class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of Array");
        int n = Int32.Parse(Console.ReadLine());
        Object[] objArr = new Object[n];

        Console.WriteLine("Enter Elements of Array");
        for(int i = 0; i < objArr.Length; i++)
        {
            objArr[i] = Console.ReadLine();
        }

        int sum = 0;
        for(int i =0;  i < objArr.Length; i++)
        {
            if (Int32.TryParse(objArr[i].ToString(),out int res))
            {
                sum += res;
            }
        }

        Console.WriteLine(sum);
    }
} 