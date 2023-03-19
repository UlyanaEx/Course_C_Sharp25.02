// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

 void Tringle (int a, int b, int c)
 {
    if (a < b + c && b < a + c && c < a + b)
    Console.WriteLine ("Трекгольник с такими длинами сторон существует");
    else
   Console.WriteLine ("Трекгольник с такими длинами сторон не существует");
 }

Console.WriteLine("Введите длину первой стороны");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину второй стороны");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину третьей стороны");
int num3 = int.Parse(Console.ReadLine()!);
Tringle (num1, num2, num3);