//Задача 35
//задайте одномерный массив из 123 чисел
//найдите кол-во элементов массива, значения которых лежат в отрезке [10,99]
int sum = 0;

int [] array = new int [123];

void FillArray (int[] arr)
{for (int i=0; i<arr.Length; i++)
    {arr[i]= new Random().Next(1,101) ;
        if (arr[i]>=10&&arr[i]<=99)
            sum++;
    }
}

void Print (int[] arr)
{for (int i =0; i<arr.Length; i++)
    {Console.Write(arr[i]+ " ");}
Console.WriteLine();
}

FillArray (array);
Print(array);
Console.WriteLine($"Количество элементов, находящихся в промежутке от 10 до 99 включительно, равно {sum}");