// В условии сказанно заполнить массив разными числами, но почему-то все в чате говорят еще и про рандомный порядок, хотя такого в условии нет.... странности... 

Console.WriteLine("a,b,c - параметры трехмерного массива");
int a;
int b;
int c;
while (true)
{
    Console.WriteLine("Введите a");
    a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите b");
    b = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите c");
    c = int.Parse(Console.ReadLine()!);
    if (a > 0 && b > 0 && c > 0 && a * b * c <= 90)
    {
        break;
    }
    else
    {
        Console.WriteLine("Слишком большой массив. Повторите попытку");
        Console.WriteLine();
    }
}

Print3DArray(CreateCube(a, b, c));

int[,,] CreateCube(int a, int b, int c)
{
    int[,,] fatMatrix = new int[a, b, c];
    int filler = 10;
    for (int i = 0; i < fatMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fatMatrix.GetLength(1); j++)
        {
            for (int t = 0; t < fatMatrix.GetLength(2); t++)
            {
                fatMatrix[i, j, t] = filler;
                filler++;
            }
        }
    }
    return fatMatrix;
}

void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int t = 0; t < arr.GetLength(2); t++)
            {
                Console.Write(arr[i, j, t] + "(" + i + "," + j + "," + t + ")" + " ");
            }
            Console.Write("\n\r");
        }
    }
}