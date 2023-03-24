// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

int[] Sum_of_string(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int[] sum = new int[row];
    //int num_string = 0;
    //int i = 0;
    for (int i = 0; i < row; i++)

    for (int j = 0; j < column; j++)
    {
        sum[i] = sum[i] + array[i, j];
      
    }
    //Console.Write($"{sum} ");
    return sum;
}

int Find_min(int[] massiv)
{
    int min = massiv[0];
    int index = 0;
    for (int i = 1; i < massiv.Length; i++)
    {
        if (massiv[i] < min)
        {
            min = massiv[i];
            index = i;
        }
           }
    return index;
}

void Print2 (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
     Console.WriteLine($"строка {i+1} - {arr[i]}"); 
    }
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
int[] sum_result = Sum_of_string(mass);
Console.WriteLine ("Сумма элементов в каждой строке");
Print2 (sum_result);
int result = Find_min(sum_result);
Console.WriteLine($"Наименьшая сумма элементов в строке {result + 1}");
