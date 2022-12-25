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
LineSort(matrix);
Print2DArray(matrix);

void LineSort(int[,] arr)
{
    int[] tempArr = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[j] = arr[i, j];
        }
        Array.Sort(tempArr);
        for (int t = 0; t < arr.GetLength(1); t++)
        {
            arr[i, t] = tempArr[t];
        }
    }
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
