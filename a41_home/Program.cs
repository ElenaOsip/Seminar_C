// Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("введите количество элементов, которые будем проверять на позитив");
int count = Convert.ToInt32(Console.ReadLine());
int [] array = new int [count];
int pos=0;
int i=0;

while (i<=count-1)
{ Console.WriteLine($"Введите {i+1}-й элемент");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i]>0)
        pos = pos +1;

    i++; 
}
Console.WriteLine("положительных чисел введенных Вами = " + pos);
