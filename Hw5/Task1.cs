int[] randarr(int size)
{
    int[] newarr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newarr[i] = new Random().Next(100, 1000);
    }

    return newarr;
}


int numberofeven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int tempsize = int.Parse(Console.ReadLine()!);

int[] myarr = randarr(tempsize);

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

Console.WriteLine(numberofeven(myarr));
