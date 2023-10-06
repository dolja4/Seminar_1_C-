// Задача. 34. 
//Задайте массив заполенный случайными положительными трехзначными числами.
// Напмшмите программу, которая покажети количество чтных чисел в массиве.




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

int CountEvenNumber(int[] arr)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] %2 == 0) count++;
}
return count;
}

void PrintArray(int[] arr)
{
    //Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    //Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(5, 100, 999);
int res = CountEvenNumber(array);
Console.Write("[");
PrintArray(array);
Console.Write($"] -> {res}");
