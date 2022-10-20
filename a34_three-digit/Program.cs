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

NewArray(arr, 100, 1000);
PrintArray (arr);

int pos = 0;
for (int i = 0; i<arr.Length; i++)
{
    if (arr[i] % 2 == 0)
        pos++;
   
}   
   
    Console.WriteLine("Количество позитивных, они же положительные;), чисел = "+ pos);

