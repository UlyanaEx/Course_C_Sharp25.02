// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии

void Output (int N)
{
if (N == 0) return;
Output (N-1);
Console.Write ($"{N} ");
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Output(num);