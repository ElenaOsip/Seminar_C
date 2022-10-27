//Задача 42
//перевести число из десятичной системы исчисления в двоичную 

Console.WriteLine("Введите десятичное число, которое мечтаете увидеть в двоичной системе");

int dec = Convert.ToInt32(Console.ReadLine());
string count=null;  //когда строка, то задаем не 0
while (dec != 0)
{
    count = dec % 2+count; 
    dec = dec/2;   // dec /=2;
}
Console.WriteLine(count);


// while (dec != 0)
// {
//     count += dec % 2; 
//     dec = dec/2;   // dec /=2;
// }

// for (int i=count.Length-1; i>=0; i--)
// {
//     Console.Write(count[i]);
// }
// Console.WriteLine();