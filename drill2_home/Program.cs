Console.WriteLine("Введите любое целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Не стесняйтесь - введите еще одно");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вам, наверно, интрересно какое из введенных вами чисел больше? Отвечаем ");

if (a>b)

{Console.WriteLine("Первое !");
 Console.WriteLine(a);
}

else

 if (a==b)
    {Console.WriteLine("Введенные вами числа равны");
    }
    
else 
{Console.WriteLine("Второе!");
Console.WriteLine(b);}
