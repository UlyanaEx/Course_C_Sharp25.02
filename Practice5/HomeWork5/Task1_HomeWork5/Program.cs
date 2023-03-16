// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве

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
        arr[i] = new Random().Next(from,to);
    }
    return arr;
}

int CheckNum(int[] arr)
{
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            a ++;      
    }
    return a;
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
int start = 100;
int stop = 999;
int[] mass = MassNums(number, start, stop);
Print(mass);
int result = CheckNum (mass);
Console.WriteLine($"количество четных элементов {result}");