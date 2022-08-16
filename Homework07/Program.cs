// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateArray (int rows, int columns, int minValue, int maxValue)
{
    double [,] newArray= new double [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +  1) + new Random().NextDouble();
    }
    return newArray;
}


void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateArray(m, n, min, max);
Show2dArray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2dArray (int[,] array)  
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 

        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
////хотела сделать метод, который будет проверять, входит ли заданный индекс 
//в массив и сразу же выдавать результат / фразу, что такого числа нет

int FindElement (int [,] array, int i, int j)
{
    if(i < array.GetLength(0) && j < array.GetLength(1))
        Console.Write(array[i, j]);
    else Console.Write("такого числа в массиве нет");
}
*/
Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2dArray (m, n, min, max);
Show2dArray (array1);

Console.Write("Введите номер строки искомого элемента: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки искомого элемента: ");
int c  = Convert.ToInt32(Console.ReadLine());

//ТАК НЕЛЬЗЯ ВЫВЕСТИ ЗНАЧЕНИЕ ВОЙДОВСКОГО МЕТОДа?
//Console.Write($"Значение элемента {r} строки {c} колонки: {FindElement(array1, r, c)}");   
if(r <= m && c < n)
    Console.Write($"Значение элемента {r} строки {c} колонки: {array1[r, c]}");
else Console.Write("Tакого числа в массиве нет");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.