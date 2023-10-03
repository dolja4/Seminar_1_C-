// 19. напишите программу, которая принимает на вход пятизначное число
// и провепяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int dig1 = number / 10000;
int dig2 = number / 1000 % 10;
int dig4 = number / 10 % 10;
int dig5 = number % 10;

bool Palindrome(int dig1,int dig2, int dig4, int dig5)
{
    return dig1 == dig5 && dig2 == dig4;
}
bool result = Palindrome(dig1,dig2,dig4,dig5);

bool check(int number)
{
if (number < 10000 || number > 99999 )
return false;
else return true;
}

if (check(number) != false)

{
    System.Console.Write(number);
    System.Console.WriteLine(result ? " -> да" : " -> нет");
}
else
System.Console.WriteLine($"{number} ->  Некорректный ввод");




// Console.WriteLine("Задача 19");
// Console.Write("Введите пятизначное число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }
// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Некорректный вввод");


// Задаяа 19(3). Палиндром. 5-ти значное число.
// int num,r,sum=0,t;
// Console.WriteLine("Введите пятизначное число: ");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
//     for(t=num;num!=0;num=num/10)
//     {
//         r=num % 10;
//         sum=sum*10+r;
//     }
// if(t==sum)
// Console.Write($"{t} является палиндромом");
// else
// Console.Write($"{t} не является палиндромом");
// } 
// else
// Console.Write("Некорректный ввод");




 