// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int Sum_figures (int N)
{
   if (N == 0) return 0;
 return Sum_figures (N/10) + N % 10;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum_figures (num));