// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Введите первое число");
string s_a = Console.ReadLine()!;
Console.WriteLine("Отлично! Введите второе число");
string s_b = Console.ReadLine()!;
Console.WriteLine("Супер! А теперь введите третье число");
string s_c = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
if (a>=b)
{
    if (a>=c)
    {
        Console.WriteLine("max = " + a);
    }
    else {
        Console.WriteLine("max = " + c);
    }
}
else if (b>=c) {
    Console.WriteLine("max = " + b);
}
else {
    Console.WriteLine("max = " + c);
}
