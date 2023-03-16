// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях

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
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        a = a + arr[i];     
    }
    return a;
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min значение элементов массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max значение элементов массива");
int stop = int.Parse(Console.ReadLine()!) + 1;
int[] mass = MassNums(number, start, stop);
Print(mass);
int result = CheckNum (mass);
Console.WriteLine($"сумма элементов массива на нечетных позициях равна {result}");