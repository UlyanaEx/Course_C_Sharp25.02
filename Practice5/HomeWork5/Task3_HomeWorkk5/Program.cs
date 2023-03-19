// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива
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

void DifMaxMin(int[] arr)
{
    int max = arr[1];
    int min  = arr[1];
    for (int i = 0; i < arr.Length; i++)
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
  Console.WriteLine(max - min);
}
Console.WriteLine("Введите количество элементов массиве");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите min значение элементов массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите max значение элементов массива");
int stop = int.Parse(Console.ReadLine()!) + 1;
int[] mass = MassNums (number, start, stop);
Print(mass);
DifMaxMin(mass);