﻿int i, count, f1 = 0, f2=1,f3 = 0;
Console.WriteLine("Enter the limit : ");

count = int.Parse(Console.ReadLine());
Console.WriteLine(f1);
Console.WriteLine(f2);

for(i=0; i<count;i++)
{
    f3 = f1 + f2;
    Console.WriteLine(f3);
    f1 = f2;
    f2 = f3;
}
Console.ReadLine();
    