/* 35 Задайте одномерный массив из 123 случайных чисел.
Найдите кол-во элементов массива, значения которых лежат
в отрезке [10,99].
пример для массива из 5 элементов
[5, 18, 123, 6, 2] -> 1*/

int CountNumbersInRange(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max)
            count++;
    }
    return count;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

   for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }   
}

int[] array = CreateArrayRndInt(123, -100, 100);

Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int result = CountNumbersInRange(array, 10, 99);
Console.WriteLine($"количество двухзначных чисел -> {result}");

