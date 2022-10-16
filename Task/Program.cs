// Задача 2. Напишите программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Большее число: {num1}");
}
else
{
    Console.WriteLine($"Большее число: {num2}");
}


// Задача 4. Напишите программу, которая принимает на вход три числа и 
// выдает максимальное из этих чисел.

Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 >= max && num2 >= num3)
{
    max = num2;
}
else
{
    max = num3;
}
Console.WriteLine($"{max} наибольшее число из {num1}, {num2}, {num3}");


// Задача 6. Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine($"число {num} является четным");
}
else{
    Console.WriteLine($"число {num} является нечетным");
}


// Задача 8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while(count <= num)
{
    if(count % 2 == 0)
    {
        Console.WriteLine($"число {count} является четным из чисел от 1 до {num}");
    }
    count++;
}



