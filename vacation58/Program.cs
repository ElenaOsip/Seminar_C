//задача 58
//найти произведение 2ух матриц
int rowA = new Random().Next(2,4);
int columnA = new Random().Next(3,5);
int rowB = columnA;
int columnB = new Random().Next(3,6); 

 int[,] arrA = new int [rowA,columnA];
 int[,] arrB = new int [rowB,columnB];

int [,] Fillarray (int [,] arr)
{for (int i =0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
            {arr[i,j]=new Random().Next(1,5);}
    }
    return arr;
}

Fillarray (arrA);
Fillarray (arrB);

void PrintArray (int[,]array)

{ for (int i=0; i<array.GetLength(0); i++)
    { for (int j=0; j<array.GetLength(1); j++)
    
    {Console.Write(array[i,j]+ " ");}
   Console.WriteLine();
    }
}
Console.WriteLine("первая матрица");
PrintArray(arrA);

Console.WriteLine();
Console.WriteLine("вторая матрица");
PrintArray(arrB);

int [,] c = new int [rowA, columnB];

void productMatrices (int [,] arr1, int[,] arr2, int [,] arrC)

{  for (int i1 = 0; i1 < arr1.GetLength(0); i1++)
        { for (int j2 = 0; j2 <arr2.GetLength(1); j2++)
           {arrC[i1,j2] =0;
                for (int j1 =0; j1<arr1.GetLength(1); j1++)
                {
                    arrC[i1,j2]=arrC[i1,j2]+arr1[i1,j1]*arr2[j1,j2];
                }
            }
        }
}
productMatrices(arrA, arrB, c);

Console.WriteLine();
Console.WriteLine("произведение данных матриц");
PrintArray(c);
   

