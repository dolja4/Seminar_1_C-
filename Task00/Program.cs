// напишите программу, которая 
// 1. на вход принимает число и
// 2. выдает его квадрат (число умноденное само на себя).
// 3. вывод результата

// например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;

Console.WriteLine(number + " -> " + result);
Console.WriteLine($"{number} -> {result}");
