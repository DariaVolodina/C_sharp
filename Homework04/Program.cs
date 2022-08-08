/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int numInDegree (int a, int b)
{
    int result = 1; 
    for(int current = 1; current <= b; current++)
    {
        result *= a;
    }
    return result;

}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input natural number: ");
int degree = Convert.ToInt32(Console.ReadLine());

int result = numInDegree(num, degree);
Console.WriteLine($"Число {num} в степени {degree} равно {result}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfDigits(int num)
{
    int result = 0, current = 0;
    while(num > 0)
    {
        current = num % 10;
        result += current;
        num/=10;

    }
    return result;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number *= -1;
int sum = SumOfDigits(number);
Console.WriteLine($"Sum of digits in number {number} is {sum} ");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] array1(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}  

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


Console.Write("Input minimum value of the array: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum value of the array: ");
int j = Convert.ToInt32(Console.ReadLine());

int [] mass = array1 (8, i, j);
ShowArray(mass);

    