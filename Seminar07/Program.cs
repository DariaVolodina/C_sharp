//Двумарный массив: СТРОКА, СТОЛБЕЦ

//Задать ДВУМЕРНЫЙ массив размером Н н М,заполненный случайными целыми числами.

int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++) //внешний цикл - обычно отвечает за прохождение по строкам
    {
        for(int j = 0; j < columns; j++) //внутренний цикл - пойдёт по элементам внутри каждой отдельной строки
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1); //присваивание, как было в одномерных массивах
        }
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) ; i++) // GetLength - более универсальная версия команды Length 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
*/

// Необходимо задать двумерный массив размера N на М, каждый элемент в котором находится по формуле a[i,j] = i + j  
//генерирует массив - вернёт матрицу, а на вход берет rows & columns

int[,] CreateIJArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++) 
    {
        for(int j = 0; j < columns; j++) 
            newArray[i,j] = i + j; 
        
    }

    return newArray;
}

Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateIJArray(m, n, min, max);
Show2dArray(array);


//задать двумерный массив и найти в нем элементы, у который оба индекса четные, и возвести эти значения в квадрат
//на вхад - массив, вернет массив

int[,] SquareOfEvenNumbers (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < array.GetLength(1); j = j + 2)
            array[i,j] *= array[i,j];
    }
    return array;
}
/*
Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
Console.WriteLine("Квадраты элементов массива с чётными индексами");
int[,] square = SquareOfEvenNumbers(array);
Show2dArray(square);
*/



//Необходимо задать двумерный массив, найти сумму элементов, находящихся на главной диагонали (оо 11 22 ...... )
// на вход массив, возвращает число

int GetSumOfDiagonal(int[,] array)
{
    int sum = 0; 

    for (int i = 0; i < array.GetLength(0) && i <array.GetLength(1); i++)
        sum += array[i, i];
    
    return sum;
}
/*
Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Console.Write("Sum of elements standing in the main diagonal is " + GetSumOfDiagonal(array));
*/