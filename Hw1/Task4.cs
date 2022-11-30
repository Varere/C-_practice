Console.WriteLine("Введите число");
string input = Console.ReadLine()!;
int N = int.Parse(input);

for (int i = 2; i <= N; i += 2){
    Console.Write($"{i} ");
}