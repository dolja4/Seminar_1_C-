// 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от1 до 7 включительно");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 7 && number >= 1)
{
    if (number <= 5 && number >= 1)
        System.Console.WriteLine($"{number} => нет");
    else Console.WriteLine($"{number} => да");
}
else Console.WriteLine("некорректный ввод");