int AboveZero(int number)
{
    int count = 0;

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите число");
        int temp = int.Parse(Console.ReadLine()!);
        if (temp > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество чисел");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine(AboveZero(size));

