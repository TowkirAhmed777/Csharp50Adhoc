﻿int i, number, fact;
Console.WriteLine("Enter the number");
number= int.Parse(Console.ReadLine());
fact = number;

for(i= number -1; i >=1; i--)
{
    fact = fact * i;

}

Console.WriteLine("\nFactorial of Given Number is:" + fact);
Console.ReadLine();