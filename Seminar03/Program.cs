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

int Number(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Введите значение координаты x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты y: ");
int y = Convert.ToInt32(Console.ReadLine());
int number;

if (x != 0 && y !=0)
{
    number = Number(x, y);
    Console.Write($"Точка относится к {number} четверти");
} 
else Console.WriteLine("Точка находится на оси координат");


Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние 
между ними в 2D пространстве.

double Length(double x1, double y1, double x2, double y2)
{
    double length = Math.Sqrt((x2-x1)*(x2-x1)*(y2-y1)*(y2-y1));
    return length;
}

Console.Write("Введите значение координаты Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double length = Length(x1, y1, x2, y2);
Console.Write($"Расстояние между точками 1 и 2 равно {length}"); 


Напишите программу, которая принимает на вход 
число (N) и выдаёт последовательность 
квадратов чисел от 1 до N.
*/
void Numbers(double num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current * current + ", ");
        current++;
    }
}

double check;
double number;
Console.Write("Введите целое положительное число: ");
check = Convert.ToDouble(Console.ReadLine());
if (check < 0) number = check * (-1);
else number = check;
Numbers(number);