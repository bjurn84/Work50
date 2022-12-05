Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();
Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (row < m & column < n)
{   Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Это число " + matrix[row, column]);
    Console.ForegroundColor = ConsoleColor.Gray;}
else Console.WriteLine("Этого нету");
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (i == row & j == column) Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(matrix[i,j] + " ");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();
}