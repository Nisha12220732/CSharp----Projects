using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StartUpOfHasina
{
    public class Cab
    {
       public string CabType{get;set;}
       public double Distance{get;set;}
       public int WaitingTime{get;set;}

       public string bookingID{get;
            set
            {
                if((value).Length == 6)
                {
                if ((value).StartsWith("AC"))
                {
                    if((char.IsDigit(value[(value).Length -1])) && (char.IsDigit(value[(value).Length -2])) && (char.IsDigit(value[(value).Length - 3])))
                    {
                        field = value;
                    }
                    else
                    {
                        throw new InvalidIDException("Invalid ID");
                    }
                }
                else
                {
                    throw new InvalidIDException("Invalid ID");
                }
                }
                else
                {
                throw new InvalidIDException("Invalid ID");
                }
            }
        }

    }
}

[Serializable]
internal class InvalidIDException : Exception
{
    public InvalidIDException()
    {
    }

    public InvalidIDException(string? message) : base(message)
    {
    }

    public InvalidIDException(string message, Exception? innerException) : base(message, innerException)
    {
    }
}