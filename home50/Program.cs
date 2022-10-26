// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого элемента в массиве нет
Console.WriteLine("В вашем массиве 3 строки и 4 столбца. Введите номер строки, а затем номер столбца элемента, чтобы узнать его значение");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());


if (row<=3 && column<=4)

{   int [,] bulk = new int [3,4];
    int [,] FillBulk (int[,] arr)
        { for (int i = 0; i < arr.GetLength(0); i++)
            { for (int j=0; j<arr.GetLength(1); j++)
            {arr[i,j] = new Random().Next(1,10);}
            } return arr;
        };
 
FillBulk(bulk);

Console.WriteLine($"В " + row + " строке и в " + column + " столбце находится число "+ bulk[row-1,column-1]);

 void Print (int[,] arr)
        { for (int i = 0; i < arr.GetLength(0); i++)
            { for (int j=0; j<arr.GetLength(1); j++)
            {Console.Write(arr[i,j]+ " ");}
            Console.WriteLine();}
        }

Console.WriteLine("Можете сами в этом убедиться");
Print(bulk);


}

else {Console.WriteLine("Элемента с введенными параментрами в данном массиве нет");};