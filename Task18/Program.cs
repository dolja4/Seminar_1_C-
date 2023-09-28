// 18. Напишите программу, кторая по заданному номеру четверти,
// показывает диапозон возможных координат точек 
//в этой четверти (x,y)

string RangeCoordinats(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x > 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}
Console.WriteLine("Введите номер четвери");
int quater = Convert.ToInt32(Console.ReadLine());

string getRangeCoordinats = RangeCoordinats(quater);

string result = getRangeCoordinats != null ? $"Заданному номеру четверти соответсвует диапазон {getRangeCoordinats}"
                                   : $"некоректный ввод";
Console.WriteLine(result);