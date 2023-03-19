// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь


int CountPositive(int num)
{
    Console.WriteLine("Введите числа");
    int a = 0;
    for (int i = 0; i < num; i++)
    {
        int n = int.Parse(Console.ReadLine()!);
        if (n > 0)
            a++;
    }
    return a;
}

Console.WriteLine("Сколько чисел будет введено?");
int n = int.Parse(Console.ReadLine()!);

int result = CountPositive(n);
Console.WriteLine($"Количество положительных чисел - {result}");