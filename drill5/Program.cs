Console.WriteLine("Введите целое положительное число (желательно не больше 20;)");
int n = Convert.ToInt32(Console.ReadLine());
if (n>20)
Console.WriteLine("Не хорошо получилось. Adios!");

else 
   { int y = - n;
while (y<= n)

{Console.Write(y); Console.Write(" ");

y++;
}
Console.WriteLine(" ");}

