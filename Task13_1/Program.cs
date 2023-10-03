int num = 789345;
int ThirdDigit(int number)
{
    while (number > 999) number /= 10;
    return number % 10;
}

int res = ThirdDigit(num);

Console.WriteLine(res);

