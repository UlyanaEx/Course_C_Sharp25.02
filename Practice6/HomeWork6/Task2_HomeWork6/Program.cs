// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем

void CrossLines (double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
        if(b1 == b2)
        Console.WriteLine("Прямые совпадают");
        else
        Console.WriteLine("Прямые параллельны");
    else
    {
    x  = (b2 - b1)/(k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({Math.Round(x,2)}; {Math.Round(y,2)})");
    //Console.WriteLine(y);
    }
}

Console.WriteLine("Введите параметры k и b для первой прямой");
double k_1 = double.Parse(Console.ReadLine()!);
double b_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите параметры k и b для второй прямой");
double k_2 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);
CrossLines (k_1, b_1, k_2, b_2);


