// Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N

void Table(int N)
{
   
    for (int i=1; i<=N; i++)
    {
        Console.WriteLine(i*i);
    }
}
int a = int.Parse(Console.ReadLine()!);
Table(a);

