﻿//double[] arr = new double[10];
//int k = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    i++;
//    arr[i] = Convert.ToDouble(Console.ReadLine());
//}
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
double[] arr = new double[10];
double[] arr2 = new double[50];
Console.WriteLine("enter array elements");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToDouble(Console.ReadLine());
}
int j = -1;
for (int i = 0; i < arr.Length; i++)
{
    if ((int)arr[i] % 2 != 0)
    {
        j += 2;
        arr2[j] = arr[i];
    }

}
int p = 0;
for (int i = 0; i < arr.Length; i++)
{
    if ((int)arr[i] % 2 == 0)
    {
        p += 2;
        arr2[p] = arr[i];
    }

}
foreach (var item in arr2)
{
    Console.WriteLine(item);
}



