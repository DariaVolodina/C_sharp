int[,] Create2dArray (int rows, int columns, int minValue)
{
    int[,] newArray = new int [rows, columns];

/* ПРОВЕРКА
    newArray[0, 0] = minValue;

    for (int i = 0, j = 1; j < newArray.GetLength(1); j++) // 1
        newArray[i, j] = newArray[i, j - 1] + 1;

    for (int j = newArray.GetLength(1) - 1, i = 1; i < newArray.GetLength(0); i++) //2
        newArray[i, j] = newArray[i - 1, j] + 1;

    for(int i = newArray.GetLength(0) - 1, j = 2; j >= 0; j--) // 3
        newArray[i, j] = newArray[i, j + 1] + 1;
 
    for (int j = 0, i = 2; i > 0; i--) //4
        newArray[i, j] = newArray[i + 1, j] + 1; 

    for (int i = 1, j = 1; j < newArray.GetLength(1) - 1; j++) //5
        newArray[i, j] = newArray[i, j - 1] + 1;

    for (int i = 2, j = 2; i < newArray.GetLength(0) - 1; i++) //6
        newArray[i, j] = newArray[i - 1, j] + 1;

    for(int i = 2, j = 1; j > 0; j--) //7
        newArray[i, j] = newArray[i, j + 1] + 1; 
*/

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

