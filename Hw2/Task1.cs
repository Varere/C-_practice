Console.WriteLine("Введите трехзначное число");
string input = Console.ReadLine()!;
int number = int.Parse(input);

number /= 10;
Console.WriteLine(number % 10);



