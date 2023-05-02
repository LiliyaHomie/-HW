//Task1 +++++++++++++++++++++++++++++
{
Task(1,true);
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом." +
"\n\t14212 -> нет" +
"\n\t12821 -> да" +
"\n\t23432 -> да\n\n");

int Num = PrintNum("Enter a five-diget number: ");
if(FiveNum(Num))
{
    Palindrom(Num);
}
}


//Task2 +++++++++++++++++++++++++++++
{
Task(2);
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве." +
"\n\tA (3,6,8); B (2,1,-7), -> 15.84" +
"\n\tA (7,-5, 0); B (1,-1,9) -> 11.53\n\n");

int x1 = SetAxisCoordinate("x", "A");
int y1 = SetAxisCoordinate("y", "A");
int z1 = SetAxisCoordinate("z", "A");

int x2 = SetAxisCoordinate("x", "B");
int y2 = SetAxisCoordinate("y", "B");
int z2 = SetAxisCoordinate("z", "B");

double DistanceBetweenCoordinates = Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2);
Console.WriteLine("\nDistance between coordinates" +
                    $"\n|x1 ({x1})| y1 ({y1})| z1 ({z1})|" +
                    $"\n---------------------------------" +
                    $"\n|x2 ({x2})| y2 ({y2})| z2 ({z2})|" +
                    $"\n\nEqual to: {DistanceBetweenCoordinates}");
}

//Task3 +++++++++++++++++++++++++++++
{
Task(3);
Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N." +
"\n\t3 -> 1, 8, 27" +
"\n\t5 -> 1, 8, 27, 64, 125\n\n");

int Num = PrintNum("Enter number: ");
if(IsPositiveNumber(Num))
    {
        for(int i = 1; i <= Num; i++)
        {
            Console.WriteLine(Pow(i,3)); //,число - возведение в степень
        }
    }
}



// Metods

int SetAxisCoordinate(string Axis, string PointName)
{
    Console.Write($"Enter the coordinate {Axis}, Point name {PointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}


double Sqrt( double Num)
{
    double t;
    double SquareRoot = Num / 2;
    do
    {
        t = SquareRoot;
        SquareRoot = (t + (Num / t)) / 2;
    }
    while ((t - SquareRoot) != 0);
    return SquareRoot;
}

double Pow( double x, double y)
{
    double Product = x;
    for(int i = 1; i < y; i++)
    {
        Product *= x;
    }
    return Product;
}

double Distance(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Sqrt(Pow(x2 - x1, 2) + //возводим в степень
                Pow(y2 - y1, 2) +
                Pow(z2 - z1, 2));
}

bool FiveNum (int num)
{
    if(num < 10000 || num > 100000)
    {
        Console.WriteLine("Number not fiveNum");
        return false;
    }
    else
    {
        return true;
    }
}

void Palindrom (int num)
{
    int NumOne = num / 10000;
    int NumTwo = num / 1000 % 10;
    int NumFour = num / 10 % 10;
    int NumFive = num % 10;
    if(NumOne == NumFive && NumTwo == NumFour)
    {
        Console.WriteLine($"\nYour number {num} is a palindrom");
    }
    else
    {
        Console.WriteLine($"\nYour number {num} is not a palindrom");
    }
}





bool IsPositiveNumber (int num)
{
    if(num < 1)
    {
        Console.WriteLine("Number is negative");
        return false;
    }
    else
    {
        return true;
    }
}




 int PrintNum (string Message)
 {
    Console.Write(Message);
    string numString = Console.ReadLine();
    int numInt = Convert.ToInt32(numString);
    return numInt;
 }


void Task(int num, bool IsFirstTask = false)
{
    if(!IsFirstTask)
    {
        Console.Write("\n\n\n Нажмите Enter для перехода к следующему заданию\n\n");
        Console.ReadKey();
    }
    Console.Write($"\n +++++++++++++++++++++++++++++++++Task {num}+++++++++++++++++++++++++++++++++\n\n\n");
} 