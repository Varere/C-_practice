int number;

while(true){
    Console.WriteLine("Введите пятизначное число");
    number = int.Parse(Console.ReadLine()!);
    number = Math.Abs(number);
    if (number >= 10000 && number < 100000) {
        break;
    } else {
        Console.WriteLine("Некорректный ввод повторите попытку");
    }
}

if(number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10){
    Console.WriteLine("Число - палиндром");
} else {
    Console.WriteLine("Число - не палиндром");
}