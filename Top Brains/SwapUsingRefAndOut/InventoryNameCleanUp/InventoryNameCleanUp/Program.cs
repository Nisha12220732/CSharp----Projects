using System;
using System.Text;
class Program
{
    public static StringBuilder FixTheCase(StringBuilder input)
    {
        input[0] = char.ToUpper(input[0]);
        for(int i = 1; i < input.Length; i++)
        {
            if (input[i-1] == ' ')
            {
              input[i] =  char.ToUpper(input[i]);
            }
        }
        return input;
    }
    public static void Main(string[] args)
    {
        string product = Console.ReadLine();
        StringBuilder productName = new StringBuilder(product);

        for(int i = 0; i < productName.Length - 1; i++)
        {
            if(productName[i] == productName[i + 1])
            {
                productName.Remove(i, 1);
                i--;
            }
        }
       

        Console.WriteLine(FixTheCase(productName));

        
    }
}
