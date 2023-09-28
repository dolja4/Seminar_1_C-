// Напишите программу, которая принимает на вход число(N)
// и выдвет таблицу квадратов чисел от 1 до N.
//5 -> 1,4,9,16, 25


void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3}    {count * count,7}");
        count ++;
    }
}

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);