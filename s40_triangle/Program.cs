//задача40
//вводят 3 числа. надо узнать может ли существовать треугольник с такими сторонами
//каждая сторона треугольника меньше суммы двух других

Console.WriteLine("Введите 3 числа, потенциальные стороны треугольника");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a<b+c && b<a+c && c <b+a)
{Console.WriteLine("Треугольнику быть!");}
else Console.WriteLine("Треугольник не может существовать");