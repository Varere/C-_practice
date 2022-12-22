Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, 0, 10);
Print2DArray(matrix);
PrintArray(AvgOfColumn(matrix));


void PrintArray(double[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + "; ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }

    Console.WriteLine("]");
}

double[] AvgOfColumn(int[,] arr)
{
    double[] avg = new double[arr.GetLength(1)];
    double temp = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            temp += arr[j, i];
        }
        avg[i] = Math.Round(temp / arr.GetLength(0), 1);
        temp = 0;
    }
    return avg;
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