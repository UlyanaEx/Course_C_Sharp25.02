// Напишите программу, которая выводит
//массив из 8 элементов, заполненный нулями и
//единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

//int[] Array = new int[8];
//
//void FillArray (int[] collection)
//{
//    int length = collection.Length;
//    int index = 0;
//    while(index<length){
//        collection[index] = new Random().Next(0,2);
//        index++;
//    }
//}
//void PrintArray (int[]col)
//{
//    int count = col.Length;
//    int position = 0;
//    while (position < count)
//    {
//        Console.WriteLine(col[position]);
//        position++;
//    }
//}
//FillArray(Array);
//PrintArray(Array);

void Massiv (int length)
{
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(2);
        Console.WriteLine(Array[i]);
    }
}
Massiv(int.Parse(Console.ReadLine()!));