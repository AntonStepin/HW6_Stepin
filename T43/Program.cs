/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

void CrossOfLinesPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = Math.Round((b2 - b1) / (k1 - k2),2);
        double y = Math.Round((k1 * x + b1),2);
        Console.WriteLine($"({x}; {y})");
    }
    else Console.WriteLine("Нет точки пересечения");
}
Console.WriteLine("Введите переменные");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Точка пересечения: ");
CrossOfLinesPoint(b1,k1,b2,k2);
