// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

void FindElenent (int[,] array, int a, int b)
{
    string result = "Такого элемента нет";
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i + 1 == a && j + 1 == b)
        result = array[i,j].ToString();
    }
Console.WriteLine (result);
}

Console.WriteLine ("Введите число строк в массиве");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число столбцов в массиве");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите диапозон значений элементов массива - min и max");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите позиции искомого элемента - i и j");
int arg1 = int.Parse(Console.ReadLine()!);
int arg2 = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
FindElenent(mass, arg1, arg2);
