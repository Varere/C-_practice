Console.WriteLine("Введите номер дня недели");
string input = Console.ReadLine()!;
int day = int.Parse(input);

switch (day) {
    case 1:
        Console.WriteLine("Нет");
        break;
    case 2:
        Console.WriteLine("Нет");
        break;
    case 3:
        Console.WriteLine("Нет");
        break;
    case 4:
        Console.WriteLine("Нет");
        break;
    case 5:
        Console.WriteLine("Нет");
        break;
    case 6:
        Console.WriteLine("Да");
        break;
    case 7:
        Console.WriteLine("Да");
        break;  
    default:
        Console.WriteLine("Некорректные данные");
        break;        
}
