//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) Console.WriteLine("Попробуйте ввести другие числа");

if(num1 > num2) Console.WriteLine(num1 + " больше, чем " + num2);
if(num2 > num1) Console.WriteLine(num2 + " больше, чем " + num1);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > max) 
    max = number2;
if(number3 > max)
    max = number3;

Console.WriteLine("Максимальное из этих чисел: " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine(num + " является чётным числом.");
else
    Console.WriteLine(num + " не является чётным числом.");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 1) 
{
    Console.Write("Введите положительное число: ");
    N = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Чётные числа: ");

if(N == 1)
{
    Console.Write(" в промежутке от 1 до " + N);
    Console.Write(" чётных чисел нет.");
}    
int current = 2;

while(current <= N)
{
    if(current % 2 == 0)
        Console.Write(current + " ");
        current ++;
}