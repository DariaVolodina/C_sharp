// ДВУМЕРНЫЕ МАССИВЫ. РЕКУРСИЯ.

//string[,] table = new string[2, 3]; 
//тип данных. запятая - две размерность (строки, столбцы)
//даём наименование table
//таблица строк

//int[,] matrix = new int[5, 8];// 5 строк, 8 столбцов  
//прямоугольная таблица чисел (в математике её называют матрица)

string[,] table = new string [2, 5];
// String.Empty
//table[0,0]   table[0,1]    table[0,2]    table[0,3]  
//table[1,0]   table[1,1]    table[1,2]    table[1,3]   
/*
table[1, 2] = "word";// обращаем к нужному элементу

for (int row = 0; row < 2; row++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.WriteLine($"-{table[row, column]}-");
    }
}

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)//matrix.GetLength(0) = 3 строки
{
    for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(1) = 4 столбика
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();//переход на новую строку
}


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)//matrix.GetLength(0) = 3 строки
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) = 4 столбика
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();//переход на новую строку
    }
}

//метод, который будет заполнять матрицу случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i< matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); //[1, 10)интервал (полуинтервал) от 1 до 10 
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
// как представить чёрно-белое изображение
// int[,] pic = new int[23, 25];
// 0 - закрашенный пиксель
// 1 - незакрашенный пиксель
// как закрасить область? по кругу (вверх, не упираемся ли в контор вбок, вниз, вправо..)

int[,] pic = new int [,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)//matrix.GetLength(0) = 3 строки
    {
        for (int j = 0; j < image.GetLength(1); j++)//matrix.GetLength(1) = 4 столбика
        {
           // Console.Write($"{image[i, j]} ");
           if(image[i,j] == 0) Console.Write($" ");//искусственно печатаем пробел
           else Console.Write($"+");
        }
    Console.WriteLine();//переход на новую строку
    }
}

void FillImage(int row, int col) // позиция, с которой начинаем закраску
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);//метод вызывает сам себя
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

PrintImage(pic);
FillImage(13, 13); //случайная точка закраски изображения. Должна быть внутри изображения!!! 
PrintImage(pic);

//РЕКУРСИЯ - это функция, которая вызывает сама себя
//вычисление факториала (5! = 5*4*3*2*1)
//5! = 5 * 4!.... и т д 
/* 
int Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1   0! = 0
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3));// 3! = 1*2*3 = 6


int Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1   0! = 0
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)//переполнение типа: Факториал от 17 Е ВМЕЩАЕТСЯ в тип данных int
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
double Factorial(int n)
{
    if(n == 1) return 1; // 1! = 1   0! = 0
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)//переполнение типа: Факториал от 17 Е ВМЕЩАЕТСЯ в тип данных int
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Также, рекурсивными функциями является
// последовательность Фибоначчи 
// 1 1 2 3 5 8 13 21...
// f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2) 

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return  1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for(int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}