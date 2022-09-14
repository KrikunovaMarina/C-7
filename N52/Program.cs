Console.WriteLine("Задайте количество строк массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
Console.WriteLine("Массив:");
FillArray(array);
PrintArray(array);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое по столбцам:"); 
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
        Console.Write($"{ sum / array.GetLength(0)}" + ";");
}
