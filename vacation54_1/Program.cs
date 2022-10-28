//Задача 54_1
//задать двумерный массив. Упорядочить по возрастанию ВЕСЬ массив 

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

Console.WriteLine("Рандомный двумерный массив:");

void PrintArray (int[,]array)

{ for (int i=0; i<array.GetLength(0); i++)
    { for (int j=0; j<array.GetLength(1); j++)
    
    {Console.Write(array[i,j]+ " ");}
   Console.WriteLine();
    }
}

PrintArray(arr);


int len = row*column;
int [] array1 = new int [len];
int z =0;
for (int i=0; i<arr.GetLength(0); i++) 
    {for (int j=0; j<arr.GetLength(1); j++ )
        {array1[z]=arr[i,j]; z++;}
    }

void PrintArray1 (int[] array)

{   int index=0;
    int length = array.Length;
    while (index<length)
    {Console.Write(array[index]+ " ");
    index ++;}
Console.WriteLine();
}
Console.WriteLine("он же, но преобразованный в одномерный:");

PrintArray1(array1);


void Select (int[] array)
{
    for(int i=0; i<array.Length-1; i++)
        {int minIndex = i;

        for (int j=i +1; j<array.Length; j++)
        {
            if (array[j]<array[minIndex]) minIndex = j;
        }
        int temporary = array [i];
        array[i]=array[minIndex];
        array[minIndex]=temporary;

        }
}


Select(array1);

Console.WriteLine("он же, но упорядоченный по возрастанию:");

PrintArray1(array1);


int[,] down = new int [row,column];
int x =0;
while (x<len)
{
    for (int r = 0; r < row; r++)
        { for (int c = 0; c< column; c++)
           { down[r,c] = array1[x];x++;}
        }
} 
Console.WriteLine("Упорядоченный по возрастанию рандомный двумерный массив:");
PrintArray(down);



