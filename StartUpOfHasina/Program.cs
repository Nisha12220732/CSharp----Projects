using System.ComponentModel.DataAnnotations;
using StartUpOfHasina;

CabDetails cs = new CabDetails();
cs.AcceptStudentDetails();

double fare = Math.Round(cs.CalculateFareAmount(),2);
System.Console.WriteLine(fare);








