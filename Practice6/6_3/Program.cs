// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1

void Fbnch (int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write (a + " ");
        (a,b) = (b,a+b);
    }
}
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
Fbnch(n);
