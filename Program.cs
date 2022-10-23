//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
//диагонали (с индексами (0,0); (1;1) и т.д.)
//Например, задан массив:
//1472
//5923
//8424
//Сумма элементов главной диагонали: 1+9+2 = 12


Console.Write("ВВедите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("ВВедите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();
int sum = SumArray(array);
Console.WriteLine(sum);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int SumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            sum += array[i,j];
        }
    }
    return sum;
}