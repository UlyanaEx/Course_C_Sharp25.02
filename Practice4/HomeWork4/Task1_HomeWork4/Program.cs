// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Degree (int a, int b)
{
     int d = 1;
    for (int i = 0; i < b; i++)
    {
        d = d * a;
    }
    return d;
}
Console.WriteLine("Введите число - основание");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - степень");
int y = int.Parse(Console.ReadLine()!);
int result = Degree(x, y);
Console.WriteLine(result);