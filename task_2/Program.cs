// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b & a > c)
{
    Console.WriteLine(a);
}
if(b > a & b > c)
{
     Console.WriteLine(b);
}
if(c > a & c > b)
{
     Console.WriteLine(c);
}
