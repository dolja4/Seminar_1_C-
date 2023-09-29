//Задача.21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2)
//     {
//         return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                Math.Pow((y2-y1), 2) + 
//                Math.Pow((z2-z1), 2));
//     }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");


double FindDistans(int ax, int ay, int az, int bx, int by, int bz)
{

    int catet1 = ax-bx;
    int catet2 = ay-by;
    int catet3 = az-bz;
    double distance = Math.Sqrt((catet1 * catet1) + (catet2 * catet2) + (catet3 * catet3));
    return distance;
}

Console.WriteLine("Введите координаты для точки А");
Console.Write("x:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("x:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z:");
int z2 = Convert.ToInt32(Console.ReadLine());

double result =  FindDistans(x1, y1, z1, x2, y2, z2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);