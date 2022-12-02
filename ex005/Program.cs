Console.WriteLine("Введите число");
string input = Console.ReadLine()!;
int number = int.Parse(input);

if (number < 0){
    number *= -1;
}

if (number < 100){
    Console.WriteLine("Третьей цифры нет");
} else {
    while (number >= 1000){
        number /= 10;
    }
    Console.WriteLine(number % 10);
}
