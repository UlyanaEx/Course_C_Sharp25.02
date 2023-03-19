// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

string Convert (int num)
{
    string binary = "";
    while (num > 0)
    {
        binary = num % 2 + binary;
        num = num / 2;
    }
    return binary;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
Convert (a);
Console.WriteLine (Convert (a));