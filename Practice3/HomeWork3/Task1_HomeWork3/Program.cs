// Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом
void Palindrom(int num)
{
    if(num/10000 == num%10 && num/1000%10 == num%100/10)
    {
        Console.WriteLine("Да! Это палиндром");
    }
    else 
    {
        Console.WriteLine("Нет! Это не палиндром");
    }
}

Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine()!);
if ((a > 9999 && a < 100000) || (a < -9999 && a > -100000))
{
    Palindrom(a);
}
else Console.WriteLine("некорректные данные");
