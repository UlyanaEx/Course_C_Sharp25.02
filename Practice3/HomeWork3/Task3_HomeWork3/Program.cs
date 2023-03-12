// Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Table(int N)
{
   
    for (int i=1; i<=N; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число");
Table(a);
