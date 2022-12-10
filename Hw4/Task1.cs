int MyPow(int num, int deg)
{
    int result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= num;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int degree = int.Parse(Console.ReadLine()!);
Console.WriteLine(MyPow(number, degree));

