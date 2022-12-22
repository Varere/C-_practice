//Не совсем понял, как задется массив. Но было бы странно, если человек сам здавший размер массива искал в нем элементы. Поэтому сделал рандом//
//Но на всякий случай оставлю ввод размера. Если что его можно вставить вместо 9 и 10 строчек//
/*Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);*/


int m = new Random().Next(1, 11);
int n = new Random().Next(1, 11);
Console.WriteLine("Введите первую координату");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первую координату");
int y = int.Parse(Console.ReadLine()!);
int[,] matrix = Create2DArray(m, n, 0, 10);
Print2DArray(matrix);
FindNumber(matrix);

void FindNumber(int[,] arr)
{
    if (x > m || x < 0 || y > n || y < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(arr[x, y]);
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
