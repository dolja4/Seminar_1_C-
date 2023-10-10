// Напишите программу, которая на вход принимает позиции
// элемента в двухмерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.




int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        //Console.WriteLine("  |");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите индекс строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2d);
if(n > array2d.GetLength(0)|| m > array2d.GetLength(1))
{
    Console.WriteLine($"{n},{m} -> такого элемента в массиве нет");
}
else if(n < 0 || m < 0)Console.WriteLine("Индекс меньше нуля");

else Console.WriteLine($"{n},{m} -> {array2d[n,m]}");
