// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b)
// {
//     Console.WriteLine($"Num {a} bigger then {b}");
// }
// else
// Console.WriteLine($"Num {b} bigger then {a}");

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int d = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max)
{
    max = b;
}
else
max = a;
if (d > max)
{
    max = d;
}

Console.WriteLine(max);

