class Program
{

    public static int[] returnMultiplicationArray(int n,int num)
    {
        int[] arr = new int[n];
        for (int i = 1; i <= n; i++)
        {
            arr[i-1] = i * num;
        }
        return arr;

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number you want Multiplication table of: ");
        int num = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number upto which you want Multiplication table: ");
        int n = Int32.Parse(Console.ReadLine());

        foreach (int i in returnMultiplicationArray(n, num))
        {
            Console.Write(i + " ");
        }
    }
    

}
