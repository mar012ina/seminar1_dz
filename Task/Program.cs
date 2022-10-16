// Задача 2. Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Большее число: {num1}");
}
else 
{
    Console.WriteLine($"Большее число: {num2}");
}
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и 
// выдает максимальное из этих чисел.

Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 >= max && num2 >= num3)
{
    max = num2;
}
else
{
    max = num3;
}
Console.WriteLine ($"{max} наибольшее число из {num1}, {num2}, {num3}") ;


