// Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе

int DigitSum (int num)
{
    int a = 0;
    for (int i = 0; num > 0; i++)
    {
        a  = a + num % 10;
        num = num / 10;
    }
   return a;
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int result = DigitSum(a);
Console.WriteLine(result);
