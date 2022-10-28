//задача 56
//задать двумерный массив.написать программу, которая будет находить строку с наименьшей
//суммой элементов


int row = new Random().Next(3,6);
int column = new Random().Next(3,4);

int[,] arr = new int [row,column];

int [,] Fillarray (int [,] arr)
{for (int i =0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
            {arr[i,j]=new Random().Next(1,30);}
    }
    return arr;
}

Fillarray (arr);

void PrintArray (int[,]array)

{ for (int i=0; i<array.GetLength(0); i++)
    { for (int j=0; j<array.GetLength(1); j++)
    
    {Console.Write(array[i,j]+ " ");}
   Console.WriteLine();
    }
}

PrintArray(arr);

//преобразовали 2й массив в одномерный с суммами элементов в строке

int [] sumRow = new int [row];
int z = 0;
for (int i=0; i<arr.GetLength(0); i++)
    {for (int j=0; j<arr.GetLength(1); j++)
        sumRow[i] = sumRow[i]+arr[i,j]; z++;
    }
   

void PrintArray1 (int[] array)

{   int index=0;
    int length = array.Length;
    while (index<length)
    {Console.Write(array[index]+ " ");
    index ++;}
Console.WriteLine();
}

Console.WriteLine("массив с суммами элементов по строкам: ");
PrintArray1(sumRow);

int minRow = sumRow [0];
int min = 0;
{for (int i = 1; i<row; i++)
    {
        if (minRow>sumRow[i]) 
           { minRow=sumRow[i]; min = i;}
    }
}
min=min+1;
Console.WriteLine(minRow);

Console.WriteLine("Строка с наименьшей суммой элементов - " + min);
   