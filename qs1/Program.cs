// See https://aka.ms/new-console-template for more information
String[] arr = new String[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("enter passenger name");
    arr[i] = Console.ReadLine();
}
Console.WriteLine("Alphabetical order");

Array.Sort(arr);
foreach(string str in arr)
{
    Console.WriteLine(str); 
}

Console.WriteLine("reverse order");
Array.Reverse(arr);
foreach (string str in arr)
{
    Console.WriteLine(str);
}

Console.WriteLine("enter name for search");
var name = Console.ReadLine();
if (arr.Contains(name)==true)
{
    Console.WriteLine($" {name} exists in the array");
}
else
{
    Console.WriteLine("not exists");
}
foreach (var str in arr)
{
    Console.WriteLine(str);
    //int length = str.Length;
    Console.WriteLine($"length ={str?.Length}");
}
foreach (string str in arr)
{
   string[] arr1= str.Split(' ');
    foreach (string st in arr1)
    {
        Console.WriteLine(st);
    }
}
for(int i = 0;i < 5;i++)
{
    for (int j = i+1 ; j < 5; j++)
    {
        if (arr[i] == arr[j]) 
        {
            Console.WriteLine($"duplicate of {arr[i]} at {j}");
        }
    }
}





