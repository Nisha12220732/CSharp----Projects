
using YogaMeditation;

class Program
{
    public static void Main(string[] args)
    {
        MemberList  arr = new MemberList();

        Console.WriteLine("Enter number of members you want to add");
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Add A Member in List");

            MeditationCenter newmember = new MeditationCenter();

            Console.WriteLine("Enter MemberID");
            newmember.MemberId = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Member age");
            newmember.Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Member Weight");
            newmember.Weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Member Height");
            newmember.Height = Double.Parse(Console.ReadLine());


            Console.WriteLine("Enter Member's Goal");
            newmember.Goal = Console.ReadLine();

            newmember.BMI = 0;

            arr.AddYogaMember(newmember);

            arr.CalculateBMI(newmember.MemberId);
        }

        arr.displayMembers();



        Console.WriteLine("Enter id");
        int id = Int32.Parse(Console.ReadLine());
        Console.WriteLine(arr.CalculateYogaFee(id));

        Console.WriteLine("Enter id");
        int id1 = Int32.Parse(Console.ReadLine());


    }
}