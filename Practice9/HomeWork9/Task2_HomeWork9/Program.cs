// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии

int Sum(int M, int N)
{
    if (N < M) return 0;
    return Sum(M, N - 1) + N;
}

Console.WriteLine("Введите число - нижнюю границу");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - верхнюю границу");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(num1, num2));