// Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве

//AB = √(xb - xa)2 + (yb - ya)2

double Distance (double x_a, double y_a, double x_b, double y_b)
{
    return Math.Sqrt(Math.Pow(x_b - x_a, 2) + Math.Pow(y_b - y_a, 2));
  
}
  Console.WriteLine (Distance(3,6,2,1));