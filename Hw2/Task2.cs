Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

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
