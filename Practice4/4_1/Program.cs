// See https://aka.ms/new-console-template for more information
//Console.WriteLine(9/10);

int FigureSum (int num)
{
    int s = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num / 10;
        s = i;
    }
    return s;
}


Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int result = FigureSum (a);
Console.WriteLine(result);
