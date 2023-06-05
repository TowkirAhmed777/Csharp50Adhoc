int num1, num2, a, b, lcmNum;
Console.Write("Enter the First number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
a = num2;
b = num1;
while (num1 != num2) 
{
    if (num1 > num2) 
    {
        num1 = num1 - num2;   
    }
    else
    {
        num2 = num2 - num1;   
    }
}
lcmNum = (a * b) / num1; 
Console.Write("LCM number: " + lcmNum);  
