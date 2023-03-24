// Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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

int[,] Find_min(int[,] massiv)
{
    int min = massiv[0, 0];
    int[,] pos = new int[1, 2];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (massiv[i, j] < min)
            {
                pos[0, 0] = i;
                pos[0, 1] = j;
                min = massiv[i, j];
            }
        }
    }
    Console.WriteLine ($"Минимальный элемент в массиве {min}");
    return pos;
}

void Print2(int[,] arr, int a, int b)
{
    int k = 0;
    int l = 0;
    int[,] crossDelArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i != a && j != b)
            {
                crossDelArr[k, l] = arr[i, j];
                Console.Write($" {crossDelArr[k, l]} ");
                l++;
            }
        }
        Console.WriteLine();
        l = 0;
        if (a != i)
          {
            k++;
          }
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число строк в массиве");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в массиве");
int num_column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапозон значений элементов массива - min и max");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
int[,] position = Find_min(mass);
Print2(mass, position[0, 0], position[0, 1]);