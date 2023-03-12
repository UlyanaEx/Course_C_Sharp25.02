// Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N

int MultiplyNum(int num)
{
    int all_mult =1;
    for (int i = 1; i <= num; i++)  
        all_mult = all_mult * i;
    return all_mult;
    
}

Console.WriteLine("ВВедите число");
int A = int.Parse(Console.ReadLine()!);
int result = MultiplyNum(A);
Console.WriteLine(result);