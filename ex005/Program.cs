/*int[] randarr(int min, int max, int size)
{
    int[] newarr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newarr[i] = new Random().Next(min, max + 1);
    }

    return newarr;
}

int[] CopyArray(int[] arr)
{
    int[] newCopy = new int[arr.Length];
    for (int i = 0; i < newCopy.Length; i++)
    {
        newCopy[i] = arr[i];
    }
    return newCopy;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ",");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите размер массива");
int tempsize = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int tempmin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int tempmax = int.Parse(Console.ReadLine()!);

int[] myarr = randarr(tempmin, tempmax, tempsize);
PrintArray(myarr);
int[] copyedArr = CopyArray(myarr);
PrintArray(copyedArr);*/

Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

Console.Write(IntersectionPoint(b1,k1,b2,k2));


Tuple<double, double> IntersectionPoint (double b1, double k1, double b2, double k2) {
    Tuple<double, double> intPoint = new Tuple<double, double> ((b2-b1) / (k1 - k2),(k1 * (b2-b1) / (k1 - k2)) + b1);
    return intPoint;
}




