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
*/

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
/*
int SumOfElements135 (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if (i % 2 == 1) sum = sum + array[i];
    
    return sum;
}
*/
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min element of the array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max element of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array012 = CreateRandomArray(size, min, max);
ShowArray(array012);
//Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в данном массиве, равна {SumOfElements135(array012)}");




//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
