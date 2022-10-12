Console.WriteLine("Введите любое число от 2 до 10");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень, в которую вы хотите возвести ваше число. Только без фанатизма, пожалуйста!");

int St = int.Parse(Console.ReadLine());

int stepen = 1;

for (int i = 1; i <=St; i ++)

    {stepen = stepen*N;
    }

Console.WriteLine("Число "+ N + " в степени "+ St +" = " + stepen);