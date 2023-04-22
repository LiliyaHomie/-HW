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

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int d = Convert.ToInt32(Console.ReadLine());

// int max = a;
// if (b > max)
// {
//     max = b;
// }
// else
// max = a;
// if (d > max)
// {
//     max = d;
// }

// Console.WriteLine(max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0)
// {
//     Console.WriteLine($"{num} четное");
// }
// else
// Console.WriteLine($"{num} нечетное");

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
if(n < 0) Console.WriteLine("Invalid");

int count = 1;

while (count <= n)
{
    if(count % 2 == 0)
    {
        Console.WriteLine($"{count} четное");
    }
    count = count + 1;
}
