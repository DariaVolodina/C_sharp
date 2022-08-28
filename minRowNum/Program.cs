//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:


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

        Console.Write(" Sum of elements: " + SumOfElements(array, i));
        Console.WriteLine();  
    }  
    Console.WriteLine();
}

int SumOfElements (int[,] array, int i)
{
    int sum = 0;
        
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j]; 

    return sum;
}

void MinRow (int[,] array)
{
    int min = 0;
    int minSum = SumOfElements(array, 0);
    
    for (int i = 0; i < array.GetLength(0) - 1; i++)
  
    {    
        if (SumOfElements(array, i + 1) < minSum) 
        {
            minSum = SumOfElements(array, i + 1);
            min = i + 1;
        }  
    }
    Console.WriteLine("Row with the least sum of elements is " + min);
          
    for (int i = 0; i < array.GetLength(0); i++)
        if (i != min && SumOfElements(array, i) == SumOfElements(array, min)) 
            Console.WriteLine("Row with the same sum of elements is " + i); 

        
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array1 = Create2dArray (m, n, min, max);
Show2dArray(array1);
MinRow(array1);

/*
int r = MinRow (array1);
Console.Write("Row with the least sum of elements is " + r);

for (int i = 0; i < array1.GetLength(0); i++)
    if (r == SumOfElements(array1, i)) Console.Write(" and " + i);

*/
