// Задача 41. Пользователь вводит с клавиатуры М чисел.
//Посчтитайте, сколько чисел больше 0 ввёл пользователь.


Console.WriteLine("Введите число - размер массива");
int arrsize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrsize];

void Massif(int arrsize)
{
    for (int i = 0; i < arrsize; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Massif(arrsize);
Console.WriteLine($"Чисел больше нуля: {CountPositiveNum(array)}");
