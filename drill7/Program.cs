Console.WriteLine("Введите любое трехзначное положительное число");
int n = Convert.ToInt32(Console.ReadLine());
if (100<=n && n<=999)
{int LastDigit = n % 10;
Console.Write("Последняя цифра данного числа = ");
Console.WriteLine (LastDigit);
}
else 
{Console.WriteLine("Будь внимательней при чтении условий задания. До свидания.");}

