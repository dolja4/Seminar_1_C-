// Напишите программу, которая принимает на вход число(N)
// и выдвет таблицу чмсел чисел от 1 до N.
//5 -> 1,4,9,16, 25


void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3}    {Math.Pow(count, 3),7}");
        count ++;
    }
}

Console.WriteLine("Введите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);


// Вариант 2.
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube)
// {
//   int count = 0;
//   int length = cube.Length;
//   while (count <  length)
//   {
//     cube[count] = Convert.ToInt32(Math.Pow(count, 3));
//     count++;
//   }
// }

// void PrintArry(int[] coll)
// {
//   int counter = coll.Length;
//   int index = 0;
//   while(index < counter)
//   {
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);