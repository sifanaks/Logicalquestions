Console.WriteLine("enter the time in hours!");
Console.WriteLine("enter rate");
int g = Convert.ToInt32(Console.ReadLine());
double h = Convert.ToDouble(Console.ReadLine());
if (6 < g && g < 9)
{
    h = h * 1.10;
    Console.WriteLine("new rate" + h);
}
else if (9 < g && g < 17)
{
    h = h * 1.20;
    Console.WriteLine("new rate" + h);
}
else if (5 < g && g < 23)
{
    h = h * 1.07;
    Console.WriteLine("new rate" + h);
}
else if (g == 23 || g == 0 || (g >= 1 && g <= 6))
{
    h = h * 1.05;
    Console.WriteLine("new rate" + h);
}
else
{
    Console.WriteLine("invalid entry");
}