// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{            
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int a = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
       {
       matrix[i, j] += a;
        a += k;
        }
    }
    return matrix;
}  
void PrintListAvr (double [] list)
{
Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]:F2}\t");
    }
}
double [] FindAverageInColumns (int [,] matrix)
{ 
   
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];         
    }
        sum = sum/matrix.GetLength(0);
        array[j] = sum;
        sum = 0;
    }
    return array;
}

     
int n, m, k;
if (args.Length >= 3) {
    n = int.Parse(args[0]);
    m = int.Parse(args[1]);
    k = int.Parse(args[2]);
    } else {    
        n = 4;
        m = 4;
        k = 2;
    }
       
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintListAvr(FindAverageInColumns(result));


