// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0 || n < 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

if (m==n)
{
    Console.WriteLine($"Сумма наьтуральных чисел от M до N равно {n*2}");
    return;
}

if(m < n) 
{
Console.Write($"Сумма натуральных элементов от M до N равно {Summa(m,n)}");   
}
else
{ 
Console.Write($"Сумма натуральных элементов от M до N равно {Summa(n,m)}"); 
}
 
int Summa(int m, int n)
{  
if (m==n)
return n;    
return m + Summa(m + 1, n);
}


