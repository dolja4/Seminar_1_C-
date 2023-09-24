// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number*-1;
int Fnumber(int number)
{
while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}
if (check(number) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine($"{number} ->  {Fnumber(number)}");






