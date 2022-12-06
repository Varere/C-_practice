Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i < number; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}

Console.Write(Math.Pow(number, 3));