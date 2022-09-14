Console.WriteLine("Задайте количество строк массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
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
Console.WriteLine("Введите индекс строки: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int y = int.Parse(Console.ReadLine());
if (x > m || y > n)
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine("число с указанными координатами" + "->" + array.GetValue(x, y));
}





