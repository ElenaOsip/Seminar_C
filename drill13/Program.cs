Console.WriteLine("Введите любое целое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int second = Convert.ToInt32(Console.ReadLine());

if (first%second == 0)

 {Console.WriteLine("Отлично! Делится без остатка!!");}

else 
{Console.WriteLine("Остаток от деления = " + first%second);}
