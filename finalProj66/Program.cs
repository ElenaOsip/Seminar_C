// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("введите два числа, сумму натуральных чисел между которыми вы хотите узнать. с надеждой, что для вас очевидно, что первое число должно быть меньше второго, в путь!");
int b = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());

int sum (int b, int e)

{ int sumnat = b;
    if (b>e) return 0;
    else return sumnat = sumnat + sum(b+1,e) ;
}
Console.WriteLine(sum (b,e));