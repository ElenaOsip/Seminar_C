//Задача 33
//задайте массив и определите присутствует ли заданное число в массиве

Console.WriteLine("Введите длину массива, который вы хотите получить.");

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

newArray(arr) ;
PrintArray(arr);

Console.Write("Какое число будем искать? ");
int num = Convert.ToInt32(Console.ReadLine());


bool BeOrNot (int [] array, int n)

{ bool b = false;
    for (int i=0; i<array.Length; i++)
    {  if (array[i] == n) 
        {
        b = true; 
        break;
        }
    }
    return b;
}

string result = BeOrNot (arr, num)? $"Примините наши искренние поздравления! Число {num} входит в данный массив." : $"Не повезло. Не входит число {num} в данный массив.";
Console.WriteLine(result);


