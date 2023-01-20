DateTime now = DateTime.Now;
Console.WriteLine("enter date of birth");
var dob = Console.ReadLine();
DateTime bdate = Convert.ToDateTime(dob);
var days = now - bdate;
Console.WriteLine($"days:{days}");
var hours = days * 24;
Console.WriteLine($"hours:{hours}");
var week = days / 7;
Console.WriteLine($"weeks:{week}");
var months = days / 30 ;
Console.WriteLine($"months:{months}");
if (bdate.Year%4==0)
{
    Console.WriteLine($"{bdate.Year} is leap year");
}
else
{
    Console.WriteLine($"{bdate.Year} is not a leap year");
}
