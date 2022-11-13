//задача 60
// создать трехмерный массив. заполнить неповторяющими двухначными числами. выдать на печать с 
// указанием индексов каждого элемента


// создание одномерного массива с двузначными неповторяющимися рандомными числами
     int[] values = new int[90];

		for (int i = 0; i < values.Length; ++i)
			values[i] = 10 + i;

		Random random = new Random();

		for (int i = 0; i < values.Length; ++i)
		{
			int index = random.Next(values.Length);

			if (i == index)
				continue;

			int tmp = values[i];

			values[i] = values[index];
			values[index] = tmp;
		}

// печать одномерного массива

	 {  int index =0;
        int length = values.Length;
        while (index<length)
    {Console.Write(values[index]+ " ");
    index ++;}
    }
Console.WriteLine();
    
    
    
    
    

 





//  преобразование одномерного массива в трехмерный
int[,,] MultiArr = new int [10,3,3]; 

int[,,] newMulti (int[] value)

{ int c=0;
    for (int i = 0; i< 10; i++)
    {   for (int j=0; j<3; j++)
        {   for (int k=0; k<3; k++)
                {MultiArr[i,j,k] = value[c];
                c++;
                }
        }
    }
    return (MultiArr);
}
newMulti(values);


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



PrintMulti(MultiArr);