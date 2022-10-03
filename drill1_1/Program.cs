int count = 0;
while (count<4)

    {   Console.WriteLine("Введите первое число");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int y = Convert.ToInt32(Console.ReadLine());
    if (n == y*y)
       { Console.WriteLine("Да! Первое число это квадрат второго)");}

    else 
    {Console.WriteLine("Нет, это не квадрат первого числа");}

    count++;
    }        
    Console.WriteLine("Отлично! На сегодня достаточно)");