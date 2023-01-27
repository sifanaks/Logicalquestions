// See https://aka.ms/new-console-template for more information
String[] arr1;
String[] arr2;
String[] arr3 = new String[20];
arr1 = new String[]{ "sifana","dona","Varsha","fathima"};
arr2 = new String[] { "Dubai", "UK", "US", "Malaysia" };
var mylist = new List<string>();
for (int i = 0; i < arr1.Length; i++)
{
    mylist.Add(arr1[i]);
    mylist.Add(arr2[i]);
}
 
arr3=mylist.ToArray();
foreach (string s in arr3)
{
    Console.WriteLine(s);
}
