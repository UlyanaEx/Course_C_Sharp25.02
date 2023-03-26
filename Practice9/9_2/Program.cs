// : Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N

void Output (int M, int N)
{
if (N < M) return;
Output (M, N-1);
Console.Write ($"{N} ");
}

Console.WriteLine("Введите число - нижнюю границу");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - верхнюю границу");
int num2 = int.Parse(Console.ReadLine()!);
Output(num1, num2);