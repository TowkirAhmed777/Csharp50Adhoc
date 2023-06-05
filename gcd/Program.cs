int num1, num2;
Console.Write("Enter the First number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number ");
num2 = Convert.ToInt32(Console.ReadLine());

while(num1 > num2)
{
    if(num1>num2)
    {
        num1 = num1 - num2;
    }
    else
    {
        num2 = num2 - num1;
    }
}

if(num1 == 1)
{
    Console.Write("No GCD Number");
}
else
{
    Console.Write("GCD Number:" + num1);
}

