Console.WriteLine("Введите любое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int cub = 0;

for (int i = 1; i < N; i ++)

{cub=Convert.ToInt32(Math.Pow(i,3));
 Console.Write (cub + ", ");
 }


cub=Convert.ToInt32(Math.Pow(N,3));
Console.WriteLine (cub);
