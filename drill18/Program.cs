Console.WriteLine("Введите номер четверти от 1 до 4!");

int n = Convert.ToInt32(Console.ReadLine());

if (n>0 && n<4)

{
    if (n ==1)
    {{Console.WriteLine("X и Y будут больше 0");}

    if (n==2)
    {Console.WriteLine("X меньше 0, а Y больше");}

    if(n==3)
     {Console.WriteLine("X и Y отрицательные числа");}
    }

    else
     {Console.WriteLine("X больше 0, а Y меньше");}
}

else {Console.WriteLine("Всего 4 четверти. Так что цифры должны быть от 1 до 4");}
