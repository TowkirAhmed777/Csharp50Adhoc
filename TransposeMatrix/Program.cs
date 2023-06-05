int[,] pos = new int[3, 3]; 
int rows, cols; 
Console.WriteLine("Enter value for Matrix:");
for (rows = 0; rows < 3; rows++)
{
    for (cols = 0; cols < 3; cols++)
    {
        pos[rows, cols] = Convert.ToInt32(Console.ReadLine()); 
    }
}
Console.WriteLine("Original Matrix:");
for (rows = 0; rows < 3; rows++)
{
    for (cols = 0; cols < 3; cols++)
    {
        Console.Write(pos[rows, cols] + "\t"); 
    }
    Console.WriteLine("");
}
Console.WriteLine("Transpose of  Matrix:");
for (rows = 0; rows < 3; rows++)
{
    for (cols = 0; cols < 3; cols++)
    {
        Console.Write(pos[cols, rows] + "\t");
    }
    Console.WriteLine("");
}