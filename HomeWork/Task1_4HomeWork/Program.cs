// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
int b = 2;
while (b <= a) {
    Console.Write(b + " ");
    b = b + 2;
}