/*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

int num1, num2;


Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("no");

//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++; //то же самое,, что и current = current+1
}

Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

1. Напишите программу, которая будет выдавать название дня недели по заданному номеру

2. Напишите программу, которая на вход принимает число и выдаёт его квадрат.

*/
