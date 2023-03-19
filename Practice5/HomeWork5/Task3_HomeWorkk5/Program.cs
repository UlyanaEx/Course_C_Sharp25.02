// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива
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

void DifMaxMin(double[] arr)
{
    double max = arr[0];
    double min  = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i]< min)
        {
            min = arr[i];
        }    
    }
    Console.WriteLine($"Максимальное значение массива {max}");
    Console.WriteLine($"Минимальное значение массива {min}");
    Console.WriteLine($"Разница между максимальным и минимальным згачениями {max} - ({min}) = {Math.Round(max-min,2)}");
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min значение элементов массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max значение элементов массива");
int stop = int.Parse(Console.ReadLine()!) + 1;
double[] mass = MassNums (number, start, stop);
Print(mass);
DifMaxMin(mass);