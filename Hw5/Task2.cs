int[] randarr(int min, int max, int size)
{
    int[] newarr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newarr[i] = new Random().Next(min, max + 1);
    }

    return newarr;
}


int sumofnumbers(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int tempsize = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int tempmin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int tempmax = int.Parse(Console.ReadLine()!);

int[] myarr = randarr(tempmin, tempmax, tempsize);

Console.Write("[");

for (int i = 0; i < tempsize; i++)
{
    if (i < tempsize - 1)
    {
        Console.Write(myarr[i] + ",");
    }
    else
    {
        Console.Write(myarr[i]);
    }
}

Console.WriteLine("]");

Console.WriteLine(sumofnumbers(myarr));


