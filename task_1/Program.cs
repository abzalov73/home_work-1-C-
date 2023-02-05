// Напишите программу, которая на вход принимает два числа и выдает какое число больше, а какое меньше
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"{a} > {b}");
}
if(a < b)
{
   Console.WriteLine($"{b} > {a}"); 
}
else
{
    Console.WriteLine($"{a} = {b}");
}
