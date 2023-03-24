// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ChangeStrings (int[,] array)
{
    int num_of_rows = array.GetLength(0);
    int num_of_columns = array.GetLength(1);
   // for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < num_of_columns; j++)
    {
        (array[0,j], array[num_of_rows - 1,j]) = (array[num_of_rows - 1,j],array[0,j]);
    }
}

Console.WriteLine ("Введите число строк в массиве");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число столбцов в массиве");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите диапозон значений элементов массива - min и max");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
ChangeStrings (mass);
Print(mass);