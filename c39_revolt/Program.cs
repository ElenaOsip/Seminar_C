//задача 39
//напишите программу, которая перевернет одномерный массив - последний элемент будет на первом месте, 
//первый на последнем и тд

int len = new Random().Next(3,15); //задаем длину массива
int [] array = new int [len];
int [] revolt = new int [len];
Console.WriteLine(len);

FillArray(array);
Print(array);

int [] FillArray (int[] arr)
{for (int i=0; i<arr.Length; i++)
   { arr[i] = new Random().Next(1,25);
    }
    return arr;
}

void Print (int [] arr)
{for(int i=0; i<arr.Length; i++)
    {Console.Write(arr[i]+ " ");}
Console.WriteLine();    
}

Revolt(array, revolt);

int [] Revolt (int[] arr, int[] arr2)
{for (int i =0; i<arr.Length; i++)
{arr2[i]=arr[arr.Length-1-i];
}
return arr2;
}

Print(revolt);