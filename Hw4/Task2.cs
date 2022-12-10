int SumOfDigits(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfDigits(number));