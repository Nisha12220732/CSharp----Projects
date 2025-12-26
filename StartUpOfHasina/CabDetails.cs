namespace StartUpOfHasina
{
    public class CabDetails
    {
        Cab cab1 = null;
        public CabDetails(){
            cab1 = new Cab();
        }
        


    public void AcceptStudentDetails()
    {    
    try{
        System.Console.WriteLine("Enter Cab details");
        System.Console.WriteLine("Enter Booking ID");
        cab1.bookingID = Console.ReadLine();
        System.Console.WriteLine("Enter CabType");
        cab1.CabType = Console.ReadLine();
        System.Console.WriteLine("Enter Distance Travelled");
        cab1.Distance = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Waiting Time");
        cab1.WaitingTime = Int32.Parse(Console.ReadLine());
       }
    catch(InvalidIDException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;

                System.Console.WriteLine(e.Message);
            }

    }


        public double CalculateFareAmount()
        {
            int ppk = 0;
            if(cab1.CabType == "Hatchback")
            {
                ppk = 10;
            }
            else if(cab1.CabType == "Sedan")
            {
                ppk = 20;
            }
            else
            {
                ppk = 30;
            }
            double waitingCharge = Math.Sqrt(cab1.WaitingTime);
            double fare = cab1.Distance * ppk + waitingCharge;
            return fare;
        }

    }
}