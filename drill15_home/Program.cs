Console.WriteLine("Ввведите цифру от 1 до 7, а мы вам скажем выходной сегодня или нет");

int n = Convert.ToInt32(Console.ReadLine());

if (n<=0 || n>7)
{
    Console.WriteLine("Сосредоточьтесь! И введите цифру от 1 до 7.");
}

else
{ if (n==6)

{
    Console.WriteLine("Суббота сегодня, отдыхаем спокойно!");
}

if (n==7)

{Console.WriteLine("Сегодня воскресенье, аккуратней там! Завтра на работу! ");}

else 
{Console.WriteLine("Не отвлекаемся! Продолжаем работать!!");}
}