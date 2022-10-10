Console.WriteLine("Введите любое положительное пятизначное число");
int p = Convert.ToInt32(Console.ReadLine());
string ar = p.ToString();
int length = ar.Length;
if (length == 5)

    if (ar[0]==ar[4]&&ar[1]==ar[3])
    {Console.WriteLine("Число ваше палиндром! Поздравляю!");
    }
    else {Console.WriteLine("Не палиндром ваше число. Может в следующий раз повезет.");}


else {Console.WriteLine("Надо было ввести положительное пятизначное число, а не то что вам вздумалось.");}