// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму.
//Если первое число не кратно второму, 
//то программа выводит остаток отделения.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно

int Remainder(int firstPar, int secondPar)
{
    return  firstPar % secondPar;
}

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(firstNumber, secondNumber);
if (remainder == 0) Console.WriteLine ("кратно");
else Console.WriteLine ($"не кратно, остаток {remainder}");
