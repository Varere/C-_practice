Console.WriteLine("Введите первое число");
string input = Console.ReadLine()!;
int first = int.Parse(input);
Console.WriteLine("Введите второе число");
input = Console.ReadLine()!;
int second = int.Parse(input);
Console.WriteLine("Введите третье число");
input = Console.ReadLine()!;
int third = int.Parse(input);
int TempMax;

if (first > second){
    TempMax = first;
} else {
    TempMax = second;
}

if (TempMax < third){
    TempMax = third;
}

Console.WriteLine(TempMax);