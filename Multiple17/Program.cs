using System;
class program
{
    public static void Main(string[] args)
    {
        int a, i;
        Console.WriteLine("multiples of 17 are : ");

        for(i=1; i<100; i++)
        {
            a = i % 17;
            if(a== 0)
            {

                Console.WriteLine(i);
            }
        }
        Console.Read();
    }

}
