﻿
while(1){
    Console.WriteLine("Введите трехзначное число");
    int number = int.Parse(Console.ReadLine()!);
    if (number >= 100 && number < 1000) {
        break;
    } else {
        Console.WriteLine("Некорректный ввод повторите попытку");
    }
}
number /= 10;
Console.WriteLine(number % 10);



