// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputNumInt(string Messadge)
        // {
        //     Console.Write(Messadge);
        //     string NumString = Console.ReadLine();
        //     int NumInt = Convert.ToInt32(NumString);
        //     return NumInt;
        // }
 
// int SetPositiveNum(string Mesadge)
//         {
//             int n = InputNumInt(Mesadge); ;
//             if (n < 1)
//             {
//                 Console.WriteLine("Error: Incorrect number entered (try again)");
//                 SetPositiveNum(Mesadge);
//             }
//             return n;
//         }

// int NaturalNumber(int n, int m)
//         {
//             if (n == m)
//             {
//                 return n;
//             }
//             else
//             {
//                 Console.Write($"{NaturalNumber(n, m + 1)}, ");
//             }
//             return m;
//         }

// Console.WriteLine(NaturalNumber(SetPositiveNum("Enter a positive number: "), 1));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int InputNumInt(string Messadge)
//         {
//             Console.Write(Messadge);
//             string NumString = Console.ReadLine();
//             int NumInt = Convert.ToInt32(NumString);
//             return NumInt;
//         }

// int SumElements(int m ,int n)
//         {
//             if (n == m)
//             {
//                 return m;
//             }
//             else
//             {
//                 return SumElements(m + 1, n) + m;
//             }
//         }

// Console.WriteLine(SumElements(m: InputNumInt("Enter M = "),
//                               n: InputNumInt("Enter N = ")));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

 int InputNumInt(string Messadge)
        {
            Console.Write(Messadge);
            string NumString = Console.ReadLine();
            int NumInt = Convert.ToInt32(NumString);
            return NumInt;
        }

int Akkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return Akkerman(m - 1, 1);
            }
            else
            {
                return Akkerman(m - 1, Akkerman(m, n - 1));
            }
        }

int m = InputNumInt("Input M: ");
int n = InputNumInt("Input N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");