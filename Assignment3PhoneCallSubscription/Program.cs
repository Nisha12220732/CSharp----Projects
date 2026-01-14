using System;
using System.Diagnostics;
using Assignment3PhoneCallSubscription;

class Program
{
    public static void Main(String[] args)
    {
        PhoneCall call = new PhoneCall();
        call.MakeAPhoneCall(true);
        System.Console.WriteLine(call.Message);
        call.MakeAPhoneCall(false);
        System.Console.WriteLine(call.Message);        
    }
}