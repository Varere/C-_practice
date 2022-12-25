Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(AkkermanFunc(m, n));

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m != 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
}