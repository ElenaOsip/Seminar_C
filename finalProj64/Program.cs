// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("введите число");
int final = Convert.ToInt32(Console.ReadLine());

string Decrease (int final)
{ if (final < 1) return String.Empty;

else return $"{final} " + Decrease (final - 1);
}

Console.WriteLine(Decrease(final));

