// Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму 
//отрицательных и положительных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue) 
{
    int[] newArray = new int[size]; //шаблон выделения памяти под массив. . команда new - выделяет память. Создали объект newArray, типа инт. и под него выделили память. 

    for(int i = 0; i < size; i++) //i отвечает за индекс
        {
            newArray[i] = new Random().Next(minValue, maxValue +1);// генерирует случайное целое число от нижней границы, вкл ее, до верхней границы, НЕ ВКЛЮЧАЯ ее
        }
    return newArray;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i +1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfPositive(int[] array)
{
    int sum = 0;
    for(int i = 0; i <array.Length; i++)
        if(array[i] > 0) sum +=array[i];
    
    return sum;
} 
/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size min Value of ellement: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size max Value of ellenent: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine("Sum of positive elements is " + SumOfPositive(array));

*/
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] Replace(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
        array[i] *= -1;
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size min Value of ellement: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size max Value of ellenent: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Replace(array);
ShowArray(array);

*/      

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
bool Presence (int[] array, int x)
{
    for(int i = 0; i < array.Length; i++) 
        if(array[i] == x) return true;
    return false;
} 

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size min Value of ellement: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size max Value of ellenent: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");
int y = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine(Presence(array, y));
*/
//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

int[] array1(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}  

int Count (int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] <= max && array[i] >= min) count++;
    }
    return count;
}

Console.Write("Input minimum value of the array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum value of the array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] mass = array1 (12, min, max);
ShowArray(mass);
Console.Write ($"Number of elements from 10 t0 90 is {Count(mass, 10, 99)}");


//Найдите произведение пар чисел в одномерном массиве. 
//Парой считается первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве

int[] NewArray (int [] array)
{
    if(array.Length % 2 == 0) 
    {
        int[] result = new int [array.Length / 2];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i]; 
        }
    }
    else 
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        result[result.Length - 1] = array[result.Length - 1];
        return result;
   }

}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size min Value of ellement: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size max Value of ellenent: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine(NewArray(array));