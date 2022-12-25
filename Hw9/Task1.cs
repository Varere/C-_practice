Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.Write(FromNToOne(n));

string FromNToOne(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n.ToString() + ", " + FromNToOne(n - 1);
    }
}