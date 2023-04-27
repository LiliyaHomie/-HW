//Task1 +++++++++++++++++++++++++++++
{
Task(1,true);
Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа" +
"\n\t456 -> 5" +
"\n\t782 -> 8" +
"\n\t918 -> 1");

int number = PrintNum("Введите число: ");

if(number < 100 || number >= 1000) 
{
    Console.WriteLine("Число не трехзначное");
    return;
}

Console.WriteLine($"Введенное число = {number}");

int secondNum = number / 10 % 10;
Console.WriteLine($"Второе число = {secondNum}");
}

//Task2 +++++++++++++++++++++++++++++
{
Task(2);
Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет" +
"\n\t645 -> 5" +
"\n\t78 -> третьей цифры нет" +
"\n\t32679 -> 6");

int number = PrintNum("Введите число: ");
if (thirdNum(number))
{
    Console.WriteLine(ThirdNum(number));
}
}
//Task3 +++++++++++++++++++++++++++++
{
Task(3);
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным" +
"\n\t6 -> да" +
"\n\t7 -> да" +
"\n\t1 -> нет");

int WeekDay = PrintNum("Введите день недели: ");
if(IsWeekDay(WeekDay))
{
    if(IsWeekend(WeekDay))
    {
        Console.WriteLine("Ура, выходной!");
    }
    else
    {
        Console.WriteLine("Не выходной:( Опять работать");
    }
}

//+++++++++++ Metods +++++++++++++++

}
bool IsWeekend(int WeekDay)
{
    if(WeekDay > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
} 

bool IsWeekDay(int WeekDay)
{
    if(WeekDay > 0 && WeekDay <= 7)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Не является днем недели");
        return false;
    }
}

bool thirdNum(int num)
{
    if (num < 100) 
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    else 
    {
        return true;
    }
}

int ThirdNum( int num)
{
    while(num > 999)
    {
        num /= 10;
    }
    return num % 10;
    
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