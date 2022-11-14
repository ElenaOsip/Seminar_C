// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("введите 2 положительных числа. если не хотите надолго зависнуть, рекомендую первое число не более 3, второе не более 11)");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int ackerman (int m, int n)
{ if (m>0&&n>0)
    return ackerman ((m-1), ackerman (m, n-1));
    else 
    if (m>0 && n == 0)
    return ackerman(m-1,1);
    else return n+1;
}

Console.WriteLine(ackerman(m,n));
