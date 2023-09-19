// Напишите программу, которая
// на вход принимает два числа и проверяет
// проверяет является ли первое квадратом второго
// а = 25, в = 5 -> да
// а = 2, в = 10 -> нет
// а = 9, в = -3 -> да
// а = -3, в = 9 -> нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите втрое число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine($"{number1} не яваяется квадратом {number2}");
}