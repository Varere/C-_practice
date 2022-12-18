Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);

Console.Write(IntersectionPoint(b1,k1,b2,k2));


Tuple<double, double> IntersectionPoint (double b1, double k1, double b2, double k2) {
    Tuple<double, double> intPoint = new Tuple<double, double> ((b2-b1) / (k1 - k2),(k1 * (b2-b1) / (k1 - k2)) + b1);
    return intPoint;
}