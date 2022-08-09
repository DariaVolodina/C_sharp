// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int Count (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0) result++;

    return result;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] NewArray (int size)
{
    int [] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }    
    return array;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


int [] array1 = NewArray(size);
ShowArray(array1);
Console.Write($"Введено {Count(array1)} элементов больше 0");
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 

//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)




double XCross (double b1, double b2, double k1, double k2)
{
    double x = ( b2 - b1 ) / ( k1 - k2);
    return x;
}

double YCross (double x, double b1, double k1)
{
    double y = k1 * x + b1;
    return y;
}


Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
double x = XCross (b1, b2, k1, k2);
double y = YCross(x, b1, k1);
Console.WriteLine($"Точка пересечения этих приямых - ({x}, {y})");

