// 16. напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно квадратом дугого.
// 5,25 -> да
//-4,16 -> да

bool ISSquareTwoNum(int num1, int num2 )
{
    return  num1 == num2*num2 || num2 == num1*num1;   
}


Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = ISSquareTwoNum(firstNumber, secondNumber);

Console.WriteLine(result ? "да" : "нет");