Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max");
int max = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, min, max);
Print2DArray(matrix);
Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в {MinSumOfLine(matrix)} строке");


int MinSumOfLine(int[,] arr)
{
    double sum = double.PositiveInfinity;
    int tempSum = 0;
    int numberOfLine = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempSum += arr[i, j];
        }
        if (tempSum < sum)
        {
            sum = tempSum;
            numberOfLine = i + 1;
        }
        tempSum = 0;
    }
    return numberOfLine;
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
