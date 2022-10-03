Console.WriteLine("Будем находить максимальное из трех чисел");

Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Есть идеи?");

Console.WriteLine("Даже если нет, вот вам ответ ");
Console.WriteLine("Максимальное число =");

if (a>b && a>c)
    Console.WriteLine(a);
  
else    
    {if (b>a && b>c)
        Console.WriteLine(b);
    else
    Console.WriteLine(c); }
    

