//  Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round (n.NextDouble()*(from + to) - from, 2);

    }
    return arr;
}

double[] CopyArr (double[] arr)
{
    double[] arr_copy = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr_copy[i] = arr[i];
    }
    return arr_copy;
}

int number = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!) + 1;
double[] mass = MassNums (number, start, stop);
Print(mass);
double[] result_copy = CopyArr (mass);
Print(result_copy);
