void NewArray (float []array)
{   int index=0;
    int length = array.Length;
    while (index<length)
    {array[index] = new Random().Next();
    index ++;}
}

void PrintArray (float []array)

{ 
    {  int index=0;
        int length = array.Length;
        while (index<length)
    {Console.Write(array[index]+ " ");
    index ++;}
    }
    
Console.WriteLine();
}


float [] arr = new float [10];

NewArray (arr);
Console.WriteLine("Заданный массив с оооочень плавающими цифрами");
PrintArray (arr);



float[] ar = new float [10];

int i = 0;

Console.WriteLine("Он же, но умноженный на беcсистемно выбранное число. Просто захотелось.");

while (i<10)

  {ar[i] = arr[i] * new Random().Next();
    Console.Write(ar[i]+ " ");
    i++;}
Console.WriteLine();


float MaxMinusMin(float [] ar)
    {   float max =  ar [0];
        float min = ar [0];
        for (int i =0; i<ar.Length; i++)
            {if (ar[i]>max)
                {max=ar[i];}
            if (ar[i]<min);
                {min=ar[i];}
            }
        return max-min;
    }

Console.WriteLine("Разница между максимальным и минимальным числом этого массива = " + MaxMinusMin(ar));
Console.WriteLine ("Дайте знать, если вам удалось это проверить;)");

