/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

void ShowDiapason (int quad)
{
    if(quad >= 1 && quad <= 4)
    {
    if(quad == 1) Console.WriteLine("x > 0, y > 0");
    if(quad == 2) Console.WriteLine("x < 0, y > 0");
    if(quad == 3) Console.WriteLine("x < 0, y < 0");
    if(quad == 4) Console.WriteLine("x > 0, y < 0");
    }
    else Console.WriteLine("Incorrect input!");
}


void ShowDiapason (int quad)
{
   while(quad < 1 || quad > 4)
   {
        Console.WriteLine("Incorrect input. Try again");
        quad = Convert.ToInt32(Console.ReadLine());
   }
    
    if(quad == 1) Console.WriteLine("x > 0, y > 0");
    if(quad == 2) Console.WriteLine("x < 0, y > 0");
    if(quad == 3) Console.WriteLine("x < 0, y < 0");
    if(quad == 4) Console.WriteLine("x > 0, y < 0");
}

Console.Write("Input number of quad: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

ShowDiapason(quadNum);

Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.
*/


/*
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 2D пространстве.
*/


/*
Напишите программу, которая принимает на вход 
число (N) и выдаёт последовательность 
квадратов чисел от 1 до N.
*/