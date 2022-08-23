//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка
/*
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

int SumOfElements (int[,] array, int i)
{
    int sum = 0;
        
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j]; 

    return sum;
}

int MinRow (int[,] array)
{
    
   
    int min = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        
        int a = SumOfElements(array, i);
        min = a;
        int b = SumOfElements(array, i+1);
        if (b < a) min = b;
    /*
        for (int ii = i + 1; ii < array.GetLength(0); ii++)
        {
            int a = SumOfElements(array, i);
            int b = SumOfElements(array, ii);
            
            if(a > b) min = ii;


        

    return min;
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
int r = MinRow (array1);
Console.Write("Row with the least sum of elements is " + r);

*/


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int[,,] Create3dArray (int blocks, int rows, int columns, int minValue, int maxValue)
{
    int[,,] newArray = new int [blocks, rows, columns];
    
    for (int b = 0; b < newArray.GetLength(0); b++)
        for (int i = 0; i < newArray.GetLength(1); i++)
            for (int j = 0; j < newArray.GetLength(2); j++)
                newArray [b, i, j] = new Random().Next(minValue, maxValue + 1);

/* Для неповторяющихся чисел 

    for (int b = 0; b < newArray.GetLength(0) - 1; b++)
        for (int i = 0; i < newArray.GetLength(1) - 1; i++)
            for (int j = 0; j < newArray.GetLength(2) - 1; j++)
                newArray [b, i, j] = new Random().Next(minValue, maxValue + 1);
                
                
                newArray [b, i, j + 1] = new Random().Next(minValue, maxValue + 1);
                newArray [b, i + 1, j] = new Random().Next(minValue, maxValue + 1);
                newArray [b + 1, i, j] = new Random().Next(minValue, maxValue + 1);

                if (newArray [b, i, j] == newArray[b, i, j + 1] || newArray [b, i, j] == newArray[b, i + 1, j] || newArray [b, i, j] == newArray[b + 1, i, j])
                    newArray[b, i, j] = new Random().Next(minValue, maxValue + 1);
                if (newArray [b, i, j + 1] == newArray[b, i + 1, j] || newArray [b, i, j + 1] == newArray[b + 1, i, j]) 
                    newArray[b, i, j + 1] = new Random().Next(minValue, maxValue + 1);
                if (newArray [b, i + 1, j] == newArray[b + 1, i, j]) 
                    newArray[b, i + 1, j] = new Random().Next(minValue, maxValue + 1);
                
VARIANT 2
                newArray [b, i, j + 1] = new Random().Next(minValue, maxValue + 1);
                while (newArray [b, i, j] != newArray[b, i, j + 1])
                    newArray[b, i, j + 1] = new Random().Next(minValue, maxValue + 1);

                newArray [b, i + 1, j] = new Random().Next(minValue, maxValue + 1);
                while (newArray [b, i + 1, j] != newArray[b, i, j] && newArray[b, i + 1, j] != newArray[b + 1, i, j])
                    newArray [b, i + 1, j] = new Random().Next(minValue, maxValue + 1);

                newArray [b + 1, i, j] = new Random().Next(minValue, maxValue + 1);
                while (newArray[b + 1, i, j] != newArray [b, i + 1, j] && newArray[b + 1, i, j] != newArray[b, i, j + 1] && newArray[b + 1, i, j] != newArray[b, i, j])
                    newArray [b + 1, i, j] = new Random().Next(minValue, maxValue + 1);
               */ 

    return newArray;
}

void Show3dArray (int[,,] array)
{
    for (int b = 0; b < array.GetLength(0); b++)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
                Console.Write($"{array[b, i, j]}({b}, {i}, {j})  ");
                
            Console.WriteLine(); 
        }    
        Console.WriteLine();  
    }
    Console.WriteLine();
}

Console.Write("Input number of blocks: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,,] array3d = Create3dArray(l, m, n, 10, 20); 
Show3dArray(array3d);
