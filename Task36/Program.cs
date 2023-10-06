// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

using System.Globalization;

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SumUnevenPosition(int[] array)
{
   int sum = 0;
   int i=1;
   while (i < array.Length)
   {
   sum = sum + array[i];
   i+=2;
   }
return sum;
}

int[] arr = CreateArray(6);
PrintArray(arr);
int sizeumUnevenPosition = SumUnevenPosition(arr);
Console.WriteLine($"-> {sizeumUnevenPosition}");
