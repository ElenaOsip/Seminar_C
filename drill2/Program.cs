// Console.WriteLine("Введите номер сегодняшнего дня недели, исходя из того, что 1 - это понедельник, 7 - воскресенье");
// int WeekDay = Convert.ToInt32(Console.ReadLine());

int count = 0;

while (count < 5)

{Console.WriteLine("Введите номер сегодняшнего дня недели, исходя из того, что 1 - это понедельник, 7 - воскресенье");
int WeekDay = Convert.ToInt32(Console.ReadLine());

    if (WeekDay == 1)
        {Console.WriteLine("Нууу, не повезло - понельник сегодня, соррян");
        count++;
        }
    if (WeekDay == 2)
        {Console.WriteLine("Сегодня вторник");
        count++;
        }
    if (WeekDay == 3)
        {Console.WriteLine("Уже среда - маленькая пятница");
        count++;
        }
    if (WeekDay == 4)
        {Console.WriteLine("Четверг, однако");
        count++;
        }
    if (WeekDay == 5)
        {Console.WriteLine("Ура!!! Пятница");
        count++;
        }        
    if (WeekDay == 6)
        {Console.WriteLine("Какие планы на выходные? Суббота ведь)");
        count++;}
    if (WeekDay == 7)
        {Console.WriteLine("Завтра на работу, воскресенье сегодня;)");
        count++;}

    if (7 < WeekDay || WeekDay < 1)
        {Console.WriteLine("Сосредоточься! В неделе всего 7 дней");
        count++;}

}
Console.WriteLine("Хватит тыкать по кнопкам! Займись уже чем то полезным;)");