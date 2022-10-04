// извините за совсем неизящное решение ;) не зная методов ..... 

int a;
Console.WriteLine("Введите любое положительное трехзначное число");

if (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Ошибка ввода! Введите ЧИСЛО!!! И не просто число, а положительное и трехзначное.");
}

else

{int n = Convert.ToInt32(a);


if (n>=100 && n<=999)


{int first = n/10;
int second = first%10;

Console.WriteLine("Вторая цифра в данном числе = " + second);
}

else 
{Console.WriteLine("Введенное число не является положительным трехзначным. Повнимательней, пожалуйста!");
}
}