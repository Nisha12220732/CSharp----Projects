class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements in the Array: ");
        int n = Int32.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Int32.Parse(Console.ReadLine());
        }

        int sum = 0;

        for(int i =0 ; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                break;
            }
            else
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
        }
        Console.WriteLine($"Sum of the Array is: {sum}");
    }
}