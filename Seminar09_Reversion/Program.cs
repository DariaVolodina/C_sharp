// Написать программу, которая выводит числа от 1 до N
/*
void ShowNums(int n)
{
    if (n != 1) ShowNums(n - 1);

    Console.Write(n + " "); //Как матрёшка. Сначала дошли до 1, потом начали выводить оттуда
} // То есть программа отрабатывает в тот момент, когда метод СВОРАЧИВАЕТСЯ

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

// Написать программу, которая выводит числа от N до 1  
/*
void ShowNums(int n)
{
    Console.Write(n + " "); // программа отрабатывает в момент РАЗВОРОТА метода
    if (n != 1) ShowNums(n - 1);
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);


//Программа, которая выведет сумму цифр в числе

int SumOfDigits(int n)
{
    if(n != 0) return n % 10 + SumOfDigits(n / 10);
    return 0; //если n == 0, то вернёт  ноль. все пути что-то вернуть должны
} //Будем продолжать цикл, пока n не равен 0
//ВОЗВРАЩАЕМ остаток от деления на 10 и + метод, который заходит глубже

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits in {num} is {SumOfDigits(num)}");


//Задайте значение М и Н, напишите программу, которая выведет все натуральные числа в промежутке от М до Н

void NaturalNums(int m, int n)
{
    if(m > n) 
    {
        int temp = n;
        n = m; 
        m = temp;
    }     

    if(m != n) NaturalNums(m, n - 1);
        Console.Write(n + " ");
}

Console.Write("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());

NaturalNums(x, y);
*/

//Напишите программу, которая на вход принимает два числа А и В
//и возводит число A в целую степень В с помощью рекурсии
int Degree (int a, int b)
{
    if(b != 0) return a * Degree(a, b - 1);
    return 1;
}

Console.Write("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Number {x} in degree {y} is {Degree(x, y)}");