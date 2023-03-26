// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Degree (int A, int B)
{
if (B == 0) return 1;
return Degree (A, B-1) * A;
}

Console.WriteLine("Введите число - основание степени");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число - степень");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree (num1, num2));