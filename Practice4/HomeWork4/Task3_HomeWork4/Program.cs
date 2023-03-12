// Напишите программу, которая задаёт массив из
//8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции
//(пригодится в следующих задачах)

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next(0,11);
        index++;
    }
}
void PrintArray (int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);