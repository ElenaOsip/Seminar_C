Console.WriteLine("Будем выяснять расстояние между точками в 3D пространстве! И не спрашивайте зачем!!! Просто введите их координаты ");
Console.WriteLine("Координаты первой точки x, y и z");

Console.WriteLine("x = ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y = ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("z = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");

Console.WriteLine("x = ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y = ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("z = ");
int  z2 = Convert.ToInt32(Console.ReadLine());


double squ = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

Console.WriteLine("Расстояние между точками = " + squ);