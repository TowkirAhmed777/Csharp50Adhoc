﻿int m, i, sum = 0, avg = 0;

Console.WriteLine("Enter the Number of Terms in the array ");

m= int.Parse(Console.ReadLine());

int[] a = new int[m];
Console.WriteLine("Enter the array elements ");
    for(i= 0; i<m; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
    for(i=0; i<m;i++)
{
    sum += a[i];
}

avg = sum / m;

Console.WriteLine("Average is {0}", avg);
Console.ReadLine();
