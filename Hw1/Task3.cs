Console.WriteLine("Введите число");
string input = Console.ReadLine()!;
int IsEven = int.Parse(input);

if (IsEven % 2 == 0){
    Console.WriteLine("Да");
} else {
   Console.WriteLine("Нет"); 
}
