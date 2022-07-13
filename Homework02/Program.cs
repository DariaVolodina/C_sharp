/* Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

int SecondNumber(int num)
{
    int SecondNum = num / 10 % 10;
    return SecondNum;
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(num);
Console.WriteLine("Second digit is " + result);


Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int ThirdDigit(int num)
{
    int thirdNum;
    if(num > 99 && num < 1000) return thirdNum = num % 10;
    else while(num >=1000) num = num / 10;
        return thirdNum = num % 10;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine("No third number"); 
else 
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Third digit of {number} is {result}");
}


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

bool Weekend(int num)
{
    if(num == 6 || num == 7) return true;
    else return false;
    
}
Console.Write("Input number from 1 to 7: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Is it a weekend?");
bool result1 = Weekend(dayNum);
Console.WriteLine(result1);
*/