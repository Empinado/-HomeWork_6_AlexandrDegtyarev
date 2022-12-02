// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координату прямой b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату прямой k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату прямой b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату прямой k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] GetCoord(double k_1, double k_2, double b_1, double b_2)
{
    double x = (b_2 - b_1) / (k_1 - k_2);
    double y = k_1 * x + b_1;
    double[] Array = { x, y };
    return Array;
}

if (k1 != k2)
{
    double[] Coord1 = GetCoord(k1, k2, b1, b2);
    Console.WriteLine("[" + string.Join(",", Coord1) + "]\n");

    Console.WriteLine("Координаты точки пересечения двух прямых:" + "(" + Coord1[0] + "," + Coord1[1] + ")");
}
else
{
    Console.WriteLine("Прямые параллельны. ");
}







