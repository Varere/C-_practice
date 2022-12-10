int[] RandArr(int min, int max, int size)
{
    int[] NewArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        NewArr[i] = new Random().Next(min, max + 1);
    }

    return NewArr;
}

Console.WriteLine("Введите размер массива");
int TempSize = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимум");
int TempMax = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимум");
int TempMin = int.Parse(Console.ReadLine()!);

int[] MyArr = RandArr(TempMin, TempMax, TempSize);

Console.Write("[" + MyArr[0] + ",");

for (int i = 1; i < TempSize; i++)
{
    Console.Write(MyArr[i] + ",");
}

Console.Write(MyArr[0] + "]");

