//Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.


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
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

void CheckNum(int[] arr, int num1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num1)
        {
            Console.WriteLine("Число есть в массиве");
            return; 
        }
    }
     Console.WriteLine("Числа нет в массиве");
}


int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int num1 = int.Parse(Console.ReadLine()!);
int[] mass = MassNums(num, start, stop);
Print(mass);
CheckNum (mass, num1);
//Print(mass);