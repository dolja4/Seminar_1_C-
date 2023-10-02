/*Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите первое целое число");
Console.Write("A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите втрое целое число");
Console.Write("B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB < 0) numB*= -1; 
int count = 1;
int step = numA;
while (count < numB)
    {
    step = step * numA ;
    count++;
    }

Console.WriteLine($" {numA} в степени {numB} -> {step}");c