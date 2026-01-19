
using System;
class Program
{

    public static void SwapByRef(ref int num1, ref int num2)
    {
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
    }

    public static void SwapByOut(int num1, int num2, out int num3,out int num4)
    {
        num3 = num2;
        num4 = num1;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter First Number");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int num2 = Int32.Parse(Console.ReadLine());

        SwapByRef(ref num1, ref num2);

        Console.WriteLine($"Your Number 1 is: {num1}");
        Console.WriteLine($"Your Number 1 is: {num2}");

        int numfinal1;
        int numfinal2;

        SwapByOut(num1, num2, out numfinal1, out numfinal2);
        Console.WriteLine($"Your Number 1 is: {numfinal1}");
        Console.WriteLine($"Your Number 1 is: {numfinal2}");
    }


}