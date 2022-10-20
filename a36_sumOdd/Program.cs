void NewArray (int []array, int from, int to)
{   int index=0;
    int length = array.Length;
    while (index<length)
    {array[index] = new Random().Next(from, to);
    index ++;}
}

void PrintArray (int[]array)

{ 
    {  int index=0;
        int length = array.Length;
        while (index<length)
    {Console.Write(array[index]+ " ");
    index ++;}
    }
    
Console.WriteLine();
}

int [] arr = new int [10];

NewArray (arr, -9, 10);
PrintArray (arr);

int sumOdd = arr[1];
for (int i=3; i<arr.Length; i=i+2)

    {sumOdd=sumOdd+arr[i];
    }
Console.WriteLine("Сумма чисел на нечетных позициях = "+ sumOdd);