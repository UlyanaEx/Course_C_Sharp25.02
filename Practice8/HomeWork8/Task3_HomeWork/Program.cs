// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц

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

int[,] Multiplication_matrix (int[,] array1, int[,] array2)
{
    
    int row1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int column2 = array2.GetLength(1);
    int[,] matrix_result = new int[column1, row2];
    if (row1 != column2)
    {Console.WriteLine ("Ошибка! Выполнить умножение матриц невозможно");
    return matrix_result;}
    else
    {
        for (int i = 0; i < column1; i++)
        for (int j = 0; j < row2; j++)
       { matrix_result[i,j] = 0;
        for (int k = 0; k < row1; k++)
        matrix_result[i,j] += array1[i,k] * array2[k,j];
       }
       return matrix_result;
}
}



Console.WriteLine("Введите число строк в матрице 1");
int num_row1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в матрице 1");
int num_column1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапозон значений элементов матрицы1 - min и max");
int start1 = int.Parse(Console.ReadLine()!);
int stop1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число строк в матрице 2");
int num_row2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в матрице 2");
int num_column2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапозон значений элементов матрицы2 - min и max");
int start2 = int.Parse(Console.ReadLine()!);
int stop2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = MassNums(num_row1, num_column1, start1, stop1);
Print(matrix1);
int[,] matrix2 = MassNums(num_row2, num_column2, start2, stop2);
Print(matrix2);
Print(Multiplication_matrix (matrix1, matrix2));