// Напишите программу, которая принимает на ввод и 
// проверяет кратно ли оно одновеменно 7 и 23
// 14 -> нет
// 46 -> нет
//161 -> да



// bool MultiplTwoNum(int num)
// {
//     return  num % 7 == 0 && num % 23 == 0;   
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool result = MultiplTwoNum(number);

// Console.WriteLine(result ? "да" : "нет");


bool MultiplTwoNum(int num, int num1, int num2 )
{
    return  num % num1 == 0 && num % num2 == 0;   
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultiplTwoNum(number, 7, 23);

Console.WriteLine(result ? "да" : "нет");