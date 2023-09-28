int num = 789345;

int res = GetThirdDigit(num);
Console.WriteLine(res);

int GetThirdDigit(int number)
{
    while (number > 999) number /= 10;
    return number % 10;
}