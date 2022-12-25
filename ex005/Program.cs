Console.WriteLine("Введите A");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите B");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(MyPower(a, b));

Console.Write(SumOfNumbers(n));

int SumOfNumbers(int n)
{
    if (n / 10 == 0)
    {
        return n;
    }
    else
    {
        return n % 10 + SumOfNumbers(n / 10);
    }
}

int MyPower(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * MyPower(a, b - 1);
    }
}
