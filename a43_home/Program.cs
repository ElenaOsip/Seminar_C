//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите два значения для первой прямой. Начнем с первого значения");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение для первой прямой");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите два значения для второй прямой. Также начнем с первого значения");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение для второй прямой");
double k2 = Convert.ToInt32(Console.ReadLine());

double x;
double y;

x = (b2-b1)/(k1-k2);
y=x*k2+b2;

Console.WriteLine("Прямые пересекаются в точке А с координатами ("+ x+", "+y+")");