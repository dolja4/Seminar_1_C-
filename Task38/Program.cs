//Задача 38. Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным элементами массива.

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}

void PrintArrayDouble(double[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
if(i < arr.Length - 1) Console.Write($"{arr[i]:F1},  ");
else Console.Write($"{arr[i]:F1},  ");
}
Console.Write("]");
}

double raz(double[] arr)
{
double min = arr[0];
double max = arr[0];
int i = 1;
while (i < arr.Length)
{
if (arr[i] < min) min = arr[i];
if (arr[i] > max) max = arr[i];
i = i + 1;
}
return max-min;
}

double[] arr = CreateArrayRndDouble(4, 1, 6);


PrintArrayDouble(arr);
Console.Write($" -> {raz(arr):F1}");

