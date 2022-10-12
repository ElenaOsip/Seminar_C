Console.WriteLine("Введите любое положительное число");
int N = int.Parse(Console.ReadLine());
int sum = 0;


while (N>0)

    {sum= sum+N%10;
    N=N/10;
    }

Console.WriteLine("Сумма цифр вашего числа = " +sum);
