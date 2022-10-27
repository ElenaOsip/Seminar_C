//Задача 37
//найдите произведение пар чисел в одномерном массиве.
//парой считаем первый и последний, второй и предпоследний и тд
//результат напишите в новом массиве


// МОЙ ВАРИАНТ

// int[] array = new int [7];

// void FillArray (int [] arr)
// {for (int i=0; i<arr.Length; i++)
//     {arr[i]=new Random().Next(1,10);}
// }

// void Print (int[] arr)
// {for (int i=0; i<arr.Length; i++)
//     {Console.Write(arr[i]+" ");}
// Console.WriteLine();    
// }

// int[] Half (int[]arr, int[]arr2)
// {for (int i=0; i<arr.Length/2; i++)
//     {
//         arr2[i]=arr[i]*arr[arr.Length-i-1];
    
// if (arr.Length%2!=0)
//     {arr2[arr.Length/2+1]=arr[arr.Length/2+1];}
//     }
//     return arr2;
// }

// int[] array2 = new int [array.Length/2+1]; 
// FillArray(array);
// Print(array);
// Half(array,array2);
// Print(array2);

//int len = array.Length/2;
// Console.WriteLine(len);
// Console.WriteLine(array.Length);

// int [] bulk = new int [len];

// void FillBulk (int[] arr)
// {
//     for (int i=0; i<len; i++)
     
//             {arr[i] = array[i]*array[array.Length-1-i];
        
//             Console.Write(arr[i]+ " ");
//             } 
//         Console.WriteLine();
// }

// void FillBulkOdd(int[]arr)
// {   for (int i=0; i<len; i++)
//         {arr[i] = array[i]*array[array.Length-1-i];
        
//         Console.Write(arr[i]+ " ");
//         } 
//         Console.Write(array[len]);
//         Console.WriteLine();
// }


// FillArray(array);
// Print(array);

// if (array.Length%2==0)
// {FillBulk(array);}
// else
// {FillBulkOdd(array);}


//ВАРИАНТ НА СЕМИНАРЕ
int len = new Random().Next(3,9); //задаем длину массива
int [] arr = new Int32[len];

Console.WriteLine(len);

double half = Math.Ceiling(Convert.ToDouble(len)/2); //чтобы округлялось в большую сторону 
                                                    //при делении нечетного числа
Console.WriteLine(half);

int [] arr2 = new Int32 [Convert.ToInt32(half)];

FillArray(arr,1,len);
Print(arr);
HalfBulk(arr,arr2);
Print(arr2);

int[] FillArray (int[] array, int from, int len)
{for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(1,10);
    }
return array;
}

void  Print(int[] array)
{for(int i=0; i<array.Length; i++)
    {Console.Write(array[i]+ " ");}
Console.WriteLine();
}

int [] HalfBulk (int [] array, int[]array2)
{for(int i=0; i<array.Length/2; i++) 
    {array2[i]=array[i]*array[array.Length-1-i];
    }
    if (array.Length % 2 != 0) 
    {array2[array.Length/2] = array [array.Length/2];
    }
return array2;
}