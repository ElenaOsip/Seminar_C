// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Какое количество строк и столбцов желаете видеть в вашем массиве? Не более 10 в каждом измерении, пожалуйста. Начнем со строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов?");
int column = Convert.ToInt32(Console.ReadLine());
double averageColumn;
int [,] bulk = new int [row,column];
double sum;
int [,] FillBulk(int [,] arr)
    { for (int j=0; j<arr.GetLength(1); j++)
        {   sum=0;
            for (int i = 0; i<arr.GetLength(0); i++)
           {arr[i,j] = new Random().Next(1,10); 
            sum = sum+arr[i,j];}
        averageColumn = sum/row;
        Console.WriteLine($"Среднее арифметическое {j+1} столбца = " + averageColumn);
        }
        return arr;
    }

void Print(int[,] arr)
{   for (int i=0; i<arr.GetLength(0); i++)
        { for (int j=0; j<arr.GetLength(1); j++)
            {Console.Write(arr[i,j]+ " ");}
    Console.WriteLine();
        }
}

FillBulk(bulk);
Console.WriteLine("Можете подсчитать сами;)");
Print(bulk);


