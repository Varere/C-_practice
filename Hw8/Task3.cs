int a1;
int b1;
int min1;
int max1;
int a2;
int b2;
int min2;
int max2;
while (true)
{
    Console.WriteLine("1ая матрица");

    Console.WriteLine("Введите a");
    a1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите b");
    b1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите min");
    min1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите max");
    max1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("2ая матрица");

    Console.WriteLine("Введите a");
    a2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите b");
    b2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите min");
    min2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите max");
    max2 = int.Parse(Console.ReadLine()!);

    if (b1 == a2)
    {
        break;
    }
    else
    {
        Console.WriteLine("Матьрицы несовместны. Повторите попытку");
        Console.WriteLine();
    }
}

int[,] first = Create2DArray(a1, b1, min1, max1);
int[,] second = Create2DArray(a2, b2, min2, max2);
Print2DArray(first);
Console.WriteLine();
Print2DArray(second);
Console.WriteLine();
Print2DArray(MatrixMultiplication(first, second));

int[,] MatrixMultiplication(int[,] first, int[,] second)
{
    int[,] answer = new int[first.GetLength(0), second.GetLength(1)];
    for (int i = 0; i < answer.GetLength(0); i++)
    {
        for (int j = 0; j < answer.GetLength(1); j++)
        {
            for (int t = 0; t < first.GetLength(1); t++)
            {
                answer[i, j] += first[i, t] * second[t, j];
            }
        }
    }
    return answer;
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

