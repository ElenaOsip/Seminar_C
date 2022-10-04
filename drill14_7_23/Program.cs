Console.WriteLine("Введите любое целое число");

int n = Convert.ToInt32(Console.ReadLine());

if (n%7 == 0 && n%23 == 0)

    {Console.WriteLine("Введенное вами число делится и на 7 и на 23");}

else 
    { Console.WriteLine("Увы и ах, не делится на 7 и/или 23");}