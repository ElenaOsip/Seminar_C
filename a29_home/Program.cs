
Console.WriteLine("Введите длину массива, который вы хотите получить. Вернее, массив какой длины вам НУЖЕН!");

int length = Convert.ToInt32(Console.ReadLine());


void newArray (int []array)
{   int index=0;
    int length = array.Length;
    while (index<length)
    {array[index] = new Random().Next(1,100);
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

int []arr= new int[length];

newArray(arr);
PrintArray(arr);