Console.WriteLine("Введите 1ое число");
string input = Console.ReadLine()!;
int first = int.Parse(input);
Console.WriteLine("Введите 2ое число");
input = Console.ReadLine()!;
int second = int.Parse(input);


if (first < second) {
    int temp = first;
    first = second;
    second = temp;
}             

if (second * second == first) {
    Console.WriteLine("ДА");
} else {
    Console.WriteLine("НЕТ");
}                    