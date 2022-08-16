/*
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




//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

int [,] ChangeRows (int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array [array.GetLength(0) - 1, j];
        array [array.GetLength(0) - 1, j] = temp;

    }
    return array;

}

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
Show2dArray(ChangeRows(array));




//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
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



int [,] ReplaceRowsColumns (int [,] array)
{
    int[,] newArray = new int [array.GetLength(0), array.GetLength(1)];

    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            newArray[j, i] = array [i, j];
                        
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

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

if (array.GetLength(0) != array.GetLength(1))
    Console.WriteLine("not square array");
else Show2dArray(ReplaceRowsColumns(array));
*/



//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
//зная ссылочные типы - можно решить иначе

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

int [,] CutArray (int [,] array)
{
    int iMin = 0, jMin =0;
    int[,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];


    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        } 

    // BREAK: если программа нашла этот элемент, цикл завершает свою работу. перейдёт на след строку
    //CONTINUE: проверка всех элементов массивов. Команда прерывает не всю операцию, а повторения цикла. Элемент будет пропущен
    
    
    for (int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
        if(i == iMin) i++;
        
        for(int j = 0, n = 0; j< array.GetLength(1); j++, n++)
        {
            if(j == jMin) j++;

            newArray[m,n] = array[i,j];
        }
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

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
Show2dArray(CutArray(array));
