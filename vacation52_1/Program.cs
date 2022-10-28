//Задача 52_1
//задать двумерный массив. Упорядочить элементы строк по убыванию

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


void Select (int[,] array)
{for(int row =0; row<array.GetLength(0); row++)
{for (int i =0; i<array.GetLength(1)-1; i++)
    { int maxIndex = i;
        for (int j=i+1; j<array.GetLength(1); j++)
            {
                if (array[row,j] > array[row,maxIndex])
                    maxIndex = j;
            }
        int temporary = array[row,i];
        array[row,i] = array[row,maxIndex];
        array[row,maxIndex]=temporary;
    }
}
}

Select(arr);
Console.WriteLine();
PrintArray(arr);