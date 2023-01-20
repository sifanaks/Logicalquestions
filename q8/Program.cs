
int[] arr = new int[5];
string[] arr2 = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("enter flight fare");
     arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter destination name");
     arr2[i] = Console.ReadLine();  
}
Console.WriteLine("enter a number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"destination:{arr2[num]}rate:{arr[num]}");
