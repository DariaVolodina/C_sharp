//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue) 
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberOfEvenNum (int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
            if(array[i] % 2 == 0) num += 1;
    
    return num;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] threeDigitArray = CreateRandomArray(size, 100, 999);
ShowArray(threeDigitArray);

Console.Write("Number of even numbers in this array is " + NumberOfEvenNum(threeDigitArray));


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] arrayNew =  new int[size];

    for(int i = 0; i < arrayNew.Length; i++)
        arrayNew[i] = new Random().Next(minValue, maxValue + 1);

    return arrayNew;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");  

    Console.WriteLine(); //отступ 
}

int SumOfElements135 (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 == 1) sum = sum + array[i];
    
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array012 = CreateRandomArray(size, min, max);
ShowArray(array012);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в данном массиве, равна {SumOfElements135(array012)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int [] RealNumArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int Difference (int [] array)
{
    int min = 0, max = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    int result = max - min;
    return result;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min element of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = RealNumArray (size, min, max);
ShowArray(array);

Console.WriteLine($"Difference between minimum and maximum elements of the array is {Difference(array)}");


/*
//ДЛЯ ТИПА DOUBLE - ошибка в строке 137, где генерируется случайный

double[] RealNumArray (int size, double minValue, double maxValue)
{
    double[] array = new double [size];
    for (int i = 0; i < array.Length; i++)
        //array[i] = new Random().NextDouble();

    return array;
}

void ShowArray (double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

double Difference (double [] array)
{
    double min = 0, max = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min element of the array: ");
double min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max element of the array: ");
double max = Convert.ToInt32(Console.ReadLine());

double [] array = RealNumArray (size, min, max);
ShowArray(array);

Console.WriteLine($"Difference between minimum and maximum elements of the array is {Difference(array)}");

*/