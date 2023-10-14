// Задача 50. Напишите программу, которая на вход принимает
//позиции элемента в дыухмерном массиве, и 
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

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
         int num = 1;
         for (int i = 0; i < n; i++)
         {
           for (int j = 0; j < m; j++)
           {
           matrix[i, j] = num;
           num += k;                   
           }      
          }
      return matrix;
     }
int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
    int[] mtrix = new int[2];
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
    {
        return mtrix;
    }
    else
    {
        mtrix[0] = matrix[rowPosition - 1, columnPosition - 1];
    }
    return mtrix;
    }

void PrintCheckIfError (int[] results, int X, int Y)     
     {      
    int x = X;
    int y = Y; 
    int res =  results[0];      
     if (res != 0) 
     Console.WriteLine($"The number in [{x}, {y}] is {res}");    
    else
    Console.WriteLine("There is no such index");              
    }   

//    void Main(string[] args) 
//    {
        int n, m, k, x, y;
        if (args.Length >= 5) 
        {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } 
        else 
        {           
           n = 3;
           m = 4;
           k = 2;
           x = 3;
           y = 3;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//    }
 