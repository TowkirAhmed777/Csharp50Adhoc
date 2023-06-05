using System;
class CubeRoot
{
    public static void Main()
    {
        double num, res;
        Console.Write("Enter the Number : ");
        num = double.Parse(Console.ReadLine());
        res = Math.Ceiling(Math.Pow(num, (double)1 / 3));
        Console.Write("Cube Root : " + res);

    }
}