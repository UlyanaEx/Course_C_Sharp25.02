//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,200);
    }
    return arr;
}

int CheckNum(int[] arr)
{
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>=10 && arr[i]<=99)
            a += 1;      
    }
    return a;
}

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(123, start, stop);
Print(mass);
Console.WriteLine(CheckNum (mass));