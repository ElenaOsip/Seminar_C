//задача 60
// создать трехмерный массив. заполнить неповторяющими двухначными числами. выдать на печать с 
// указанием индексов каждого элемента


// заполнение трехмерного массива двузначными числами
// int[,,] MultiArr = new int [4,3,4]; 

// int[,,] newMulti (int[,,] array)
// { for (int i = 0; i< array.GetLength(0); i++)
//     {   for (int j=0; j<array.GetLength(1); j++)
//         {   for (int k=0; k<array.GetLength(2); k++)
//                 {array[i,j,k] = new Random().Next(10,100);
                
//                 }
//         }
//     }
//     return array;
// }


//создание одномерного массива с неповторяющимися двузначными числами 


HashSet<int> numbers = new HashSet<int>();

for (int i = 10; i < 100; i++) 
{
    numbers.Add(i); 
}

int[]arr = numbers.ToArray();




 //преобразование одномерного массива в трехмерный
int[,,] MultiArr = new int [10,3,3]; 

int[,,] newMulti (int[] array)

{ int c=0;
    for (int i = 0; i< 10; i++)
    {   for (int j=0; j<3; j++)
        {   for (int k=0; k<3; k++)
                {MultiArr[i,j,k] = array[c];
                c++;
                }
        }
    }
    return (MultiArr);
}



int [,,] PrintMulti (int[,,] array)
{for (int i = 0; i< array.GetLength(0); i++)  
    {   for (int j=0; j<array.GetLength(1); j++)
        {   for (int k=0; k<array.GetLength(2); k++)
                {Console.Write( $"{array[i,j,k]} ({i}, {j}, {k}) ");}
        Console.WriteLine();
        }
        Console.WriteLine();
    }
    return array;
}


newMulti(arr);
PrintMulti(MultiArr);