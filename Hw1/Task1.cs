Console.WriteLine("Введите первое число");
string input = Console.ReadLine()!;
int first = int.Parse(input);
Console.WriteLine("Введите второе число");
input = Console.ReadLine()!;
int second = int.Parse(input);

if (first > second){
    Console.WriteLine($"max = {first}");
} else {
    Console.WriteLine($"max = {second}");
}
