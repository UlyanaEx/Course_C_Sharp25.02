// Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y)

void Coordinates (int Quater)
{
    if (Quater == 1)
    Console.WriteLine ("x > 0, y > 0");

    else if (Quater == 2)
    Console.WriteLine ("x < 0, y > 0");
    
    else if (Quater == 3)
    Console.WriteLine ("x < 0, y < 0");

    else if (Quater == 4)
    Console.WriteLine ("x > 0, y < 0");
}

int num = int.Parse(Console.ReadLine()!);
Coordinates(num);
