// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве

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

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int flex_size = size / 2 + size % 2;
    int[] new_arr = new int[flex_size];

    for (int i = 0; i < size/2; i++)
    {
        new_arr[i] = arr[i] * arr[size - i -1];   
    }
    
    if (size % 2 == 1)
    {
        new_arr[flex_size - 1] = arr[size/2];
    }
    return new_arr;
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min значение элементов массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max значение элементов массива");
int stop = int.Parse(Console.ReadLine()!) + 1;
int[] mass = MassNums(number, start, stop);
Print(mass);
int[] result = PairsNum (mass);
Print(result);
//Console.WriteLine(new_arr);
