﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int [,] Create2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] array = new int [rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();   
    }    
    Console.WriteLine();
}

int[,] SortRows (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1) - 1; j++)
         
            for (int k = j + 1; k < array.GetLength(1); k++)
                if(array [i, j] < array [i, k]) 
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
        
    
    return array;    

}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array2d = Create2dArray (m, n, min, max);
Show2dArray(array2d);
int [,] sortArray = SortRows (array2d);
Show2dArray (sortArray);

*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] Create2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int [rows, columns];

    for(int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray [i, j] = new Random().Next(minValue, maxValue + 1);
        
    return newArray;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();  
    }  
    Console.WriteLine();
}

int[,] MultArrays(int[,] arrayFirst, int[,] arraySecond) //if arrays have the same size
{
    int[,] newArray = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(1)]; 
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
            newArray[i, j] = arrayFirst[i, j] * arraySecond[i, j];
    
    return newArray;
}

Console.Write("Input number of rows for both of the arrays: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns for both of the arrays: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum element of the first array: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum element of the first array: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum element of the second array: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum element of the second array: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2dArray(m, n, min1, max1);
int[,] array2 = Create2dArray(m, n, min2, max2);
Show2dArray (array1);
Show2dArray (array2);

Console.WriteLine("Произведение двух матриц ниже");
int[,] array3 = MultArrays(array1, array2);
Show2dArray(array3);

*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)



//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] Create2dArray (int rows, int columns, int minValue)
{
    int[,] newArray = new int [rows, columns];

    int iMax = newArray.GetLength(0) - 1;
    int jMax = newArray.GetLength(1) - 1;
    int iMin = 0;
    int jMin = 0; 

    for (int r = 0; r <= iMax / 2; r++) 
    {
        
        for (int i = iMin + r, j = jMin + r; j <= jMax - r; j++) // 1
        { 
            if (i == 0 && j == 0) newArray[i, j] = minValue;
            else newArray[i, j] = newArray[i, j - 1] + 1;
        }
        for (int j = jMax - r, i = iMin + r + 1; i <= iMax - r; i++) //2
            newArray[i, j] = newArray[i - 1, j] + 1;

        for(int i = iMax - r, j = jMax - r - 1; j >= jMin + r; j--) // 3
            newArray[i, j] = newArray[i, j + 1] + 1;
 
        for (int j = jMin + r, i = iMax - r - 1; i > iMin + r; i--) //4
            newArray[i, j] = newArray[i + 1, j] + 1; 
    }

    return newArray;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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

int[,] array = Create2dArray(m, n, min);
Show2dArray (array);