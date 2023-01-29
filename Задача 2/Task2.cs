//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Clear();

Console.Write("Введите первое число: ");

int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
int number;

if (number1 > number2)
{
   number = number1;
} 
else number = number2;
{
    Console.WriteLine($"number = {number1} > {number2}");
}