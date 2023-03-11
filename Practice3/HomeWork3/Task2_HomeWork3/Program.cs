// Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.

double Distance (double x_a, double y_a, double z_a, double x_b, double y_b, double z_b)
{
    return Math.Sqrt(Math.Pow(x_b - x_a, 2) + Math.Pow(y_b - y_a, 2) + Math.Pow(z_b - z_a, 2));
  
}
Console.WriteLine("Введите координаты первой точки");
double a = double.Parse(Console.ReadLine()!);
double b = double.Parse(Console.ReadLine()!);
double c = double.Parse(Console.ReadLine()!);
  
Console.WriteLine("Введите координаты второй точки");
double d = double.Parse(Console.ReadLine()!);
double e = double.Parse(Console.ReadLine()!);
double f = double.Parse(Console.ReadLine()!);
  
Console.WriteLine (Distance(a,b,c,d,e,f));