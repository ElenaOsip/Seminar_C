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


void OppositeSign (int[]array)

{ for (int i=0; i<array.Length; i++)
    {array[i]=-array[i];}

}
int []arr= new int[4];

NewArray(arr, -9, 9);
PrintArray(arr);

OppositeSign(arr);
PrintArray(arr);
