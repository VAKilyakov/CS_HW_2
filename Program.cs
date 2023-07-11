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