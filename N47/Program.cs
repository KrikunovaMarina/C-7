Console.WriteLine("введите число m ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("введите число n ");
int n = int.Parse(Console.ReadLine());
double[,] a =new double[m,n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble() * 10;
        Console.Write(a[i, j]);
    }
    Console.WriteLine();
}
