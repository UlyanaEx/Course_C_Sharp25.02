// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
string s_a = Console.ReadLine()!;
Console.WriteLine("Введите второе число");
string s_b = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = int.Parse(s_b);
if (a<b)
{
    Console.WriteLine("max = " + b);
    Console.WriteLine("min = " + a);
}
else if (a == b)
{
    Console.WriteLine("max = min = " + b);
}
else 
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}

