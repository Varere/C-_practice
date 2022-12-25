Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumOfRow(m, n));

int SumOfRow(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumOfRow(m, n - 1);
    }
}