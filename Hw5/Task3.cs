// Переделал вывод массива и использовал Round


double[] randarr(double min, double max, int size)
{
    double[] newarr = new double[size];

    for (int i = 0; i < size; i++)
    {
        newarr[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
    }

    return newarr;
}

double deltamax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    double count = max - min;
    return Math.Round(count, 2);
}

Console.WriteLine("Введите размер массива");
int tempsize = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
double tempmin = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
double tempmax = double.Parse(Console.ReadLine()!);

double[] myarr = randarr(tempmin, tempmax, tempsize);

Console.Write("[");

for (int i = 0; i < tempsize; i++)
{
    if (i < tempsize - 1)
    {
        Console.Write(myarr[i] + "; ");
    }
    else
    {
        Console.Write(myarr[i]);
    }
}

Console.WriteLine("]");

Console.WriteLine(deltamax(myarr));

