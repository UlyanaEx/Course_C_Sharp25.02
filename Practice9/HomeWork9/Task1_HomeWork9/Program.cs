// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии

void Output(int M, int N)
{
    if (N % 2 != 0)
        N = N - 1;

    if (N < M) return;
    Output(M, N - 2);
    Console.Write($"{N} ");
}

Console.WriteLine("Введите число - нижнюю границу");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - верхнюю границу");
int num2 = int.Parse(Console.ReadLine()!);
Output(num1, num2);