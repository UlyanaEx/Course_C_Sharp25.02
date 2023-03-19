// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)

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

// Решение 1. Мое. Создала новый массив такого же размера, что и исходный. Заполнила по умолчанию 0
// Затем подтянула значения из исходного в обратном порядке

// int[] Reverse(int[] arr)
// {
//     int size = arr.Length;
//     int[] new_arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         new_arr[i] = arr[size - i - 1];
//     }
//     return new_arr;
// }
// Console.WriteLine("Введите количество элементов массиве");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите min значение элементов массива");
// int start = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите max значение элементов массива");
// int stop = int.Parse(Console.ReadLine()!) + 1;
// int[] mass = MassNums(number, start, stop);
// Print(mass);
// int[] result = Reverse (mass);
// Print(result);
// 

void RevMass (int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        (arr[i], arr[arr.Length - i -1]) = (arr[arr.Length - i -1], arr[i]);
    }
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min значение элементов массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max значение элементов массива");
int stop = int.Parse(Console.ReadLine()!) + 1;
int[] mass = MassNums(number, start, stop);
Print(mass);
RevMass(mass);
Print(mass);