//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void ShowNums (int m, int n)
{
    if(m > n)
    {
        int temp = m; 
        m = n; 
        n = temp;
    }
    if(m != n) ShowNums (m, n - 1);
    Console.Write(n + " ");
}

Console.Write("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());

ShowNums(x, y); 
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumOfNums(int m, int n)
{
    if(m > n)
    {
        int temp = m; 
        m = n; 
        n = temp;
    }

    if(n != m) return n + SumOfNums(m, n - 1);
    return m;
}

Console.Write("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of all numbers from {x} to {y} is {SumOfNums(x, y)}"); 
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return  Akkerman (m - 1, 1);

    return  Akkerman (m - 1, Akkerman(m, n - 1));
}

Console.Write("Input first positive integer number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second positive integer number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана для чисел {x} и {y} = {Akkerman(x, y)}");

