/* Задача 1

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/* Решение 1
int CutNumber(int Number)
{
    int DelHunders = Number % 100;
    int DelUnits = DelHunders / 10;

    int Result = DelUnits;

    return Result;
}

Console.Write("Enter a three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >=1000)
{
    Console.Write("You number is't three - digit");
    return;
}

int NewNuber = CutNumber ( number );

Console.Write("The second digit is: " + NewNuber);
*/

/* Тесты 1
PS D:\Home_Works\CS_HW_2> dotnet run
Enter a three-digit number 456
The second digit is: 5
PS D:\Home_Works\CS_HW_2> dotnet run 
Enter a three-digit number 782
The second digit is: 8
PS D:\Home_Works\CS_HW_2> dotnet run
Enter a three-digit number 918
The second digit is: 1
PS D:\Home_Works\CS_HW_2>
*/

/* Задача 2
Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/* Решение 2
int CutNumber(int Number)
{
    while (Number > 999)
    {
        Number = Number / 10;        
    }

    return Number % 10;

}

Console.Write("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.Write("You number is smoller 100");
}
else
{
    Console.Write("The third digit is: " + CutNumber(number));
}
*/

/* Тесты 2
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number 645
The third digit is: 5
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number 78
You number is smoller 100
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number 32679
The third digit is: 6
*/

/* Задача 3
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/* Решение 3
bool Weekend (int Number)
{
    bool Result = false;
    if (Number >=6)
    {
        Result = true;
    }

       return Result; 
}

Console.Write("Enter number day of week ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0 || number >7)
{
    Console.Write("You number is'n day of week");
}
else
{
    if (Weekend(number))
    {
        Console.Write("Yes day is weekend");    
    }
    else
    {
        Console.Write("No day is't weekend");
    }
}
*/

/* Тесты 3
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number day of week 8
You number is'n day of week
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number day of week 6
Yes day is weekend
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number day of week 7
Yes day is weekend
PS D:\Home_Works\CS_HW_2> dotnet run
Enter number day of week 1
No day is't weekend
*/