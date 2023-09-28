//20. Напишите программу, которая принимает на вход 
// координаты двух точек и находит 
// расстояние между ними в 2D.
// А(3,6); B(2,1)-> 5,09
// А(7,-5); B(1,-1)-> 7,21

double FindDistans(int ax, int ay, int bx, int by)
{

    int catet1 = ax-bx;
    int catet2 = ay-by;
    double distance = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
    return distance;
}

Console.WriteLine("Введите координаты для точки А");
Console.Write("x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("x:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y2 = Convert.ToInt32(Console.ReadLine());

double result =  FindDistans(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);
