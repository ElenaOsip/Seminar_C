Console.WriteLine("Введите любое целое число");

int n = Convert.ToInt32(Console.ReadLine());

if (n<0)

{Console.WriteLine("Я пока не знаю что делать с отрицательными числами, так что, До свидания!");

}

else
{

string array = n.ToString();

int index = array.Length;

if (index>=3)

{Console.WriteLine("Третья цифра данного числа = " + array[2]);
}

else 
{Console.WriteLine("А вот нет в вашем числе третьей цифры. Извиняйте.)");
}
}