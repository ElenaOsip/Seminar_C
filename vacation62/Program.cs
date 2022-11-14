// Заполнить двумерный массив по спирали

Console.WriteLine("Будем заполнять КВАДРАТНУЮ матрицу по спирали. Введите любое количество строк/столбцов, но не более 10. ");
int row = Convert.ToInt32(Console.ReadLine());

int count = row*row;
int rcount =0; int ccount =0;
int num =1;
int column = row;
int [,] arraySpir = new int [row,column];
int i=0; int j=0;

while (num<=count)

{ 
    i = rcount; 
    for (j=ccount; j<column && arraySpir[i,j]==0; j++)
    {arraySpir[i,j]=num;
        num++;}

rcount++; ccount=j-1; column --;
  
    j=ccount;
    for (i=rcount; i< row&&arraySpir[i,j]==0; i++)
        {arraySpir[i,j]=num; 
            num++;
        }

rcount=i-1; ccount=j-1; row--;
    
    i=rcount;
    for (j=ccount; j>=0&&arraySpir[i,j]==0; j--)
    {arraySpir[i,j] = num;
        num++;
    }
rcount--; ccount=j+1;

j=ccount;
for(i=rcount; i>0&&arraySpir[i,j]==0; i--)
{arraySpir[i,j]=num; 
num++;}
rcount=i+1; ccount++;
}


void PrintArray (int[,] matr)

{ for (int i = 0; i< matr.GetLength(0); i++)
   { for (int j=0; j< matr.GetLength(1); j++)
    { if (matr[i,j]<10)
        Console.Write("0"+matr[i,j]+ " ");
    else
        Console.Write(matr[i,j]+ " ");
        }
Console.WriteLine();
   }  
}


PrintArray(arraySpir);


