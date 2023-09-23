// 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = SecondDigit(number);
if (number < 0) number*= -1;
if (number >= 100 && number <= 999)  

Console.WriteLine($"{number} -> {secondDigit}");

int SecondDigit(int num)
{
    int interDigit = num / 10;
    int secondDigit = interDigit %10;
    return secondDigit;
}


// if (number < 0) number*= -1;
// if (number >= 100 && number <= 999)  


// {
//     int interDigit = number / 10;
//     int secondDigit = interDigit %10;
//     Console.WriteLine($" Вторая цифра введенного числа: {secondDigit}");
// }
//else Console.WriteLine("Некоректный ввод");

