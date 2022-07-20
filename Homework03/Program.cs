/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


bool Palindrome (int Number)
{
    int a = Number / 10000;
    int b = Number / 1000 % 10;
    int d = Number % 100 / 10; 
    int e = Number % 10;

    if (a == e && b == d) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000) 
{
    Console.Write("Число должно быть пятизначным. Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

bool result = Palindrome(number);
if (result == true) Console.WriteLine ("Это число является палиндромом.");
if (result == false) Console.WriteLine ("Это число НЕ является палиндромом.");


/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


double Distance (double Xa, double Ya, double Za, double Xb, double Yb, double Zb)
{
    double result = Math.Sqrt ((Xb - Xa) *(Xb - Xa) + (Yb - Ya) *(Yb - Ya) + (Zb - Za) *(Zb - Za));
    return result;
}

Console.Write("Введите значение координаты Х точки A: ");
double Xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение координаты Y точки A: ");
double Ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение координаты Z точки A: ");
double Za = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение координаты Х точки B: ");
double Xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
double Yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B: ");
double Zb = Convert.ToDouble(Console.ReadLine());

double distance = Distance(Xa, Ya, Za, Xb, Yb, Zb);
Console.WriteLine($"Расстояние между точками А и В равно {distance}");
/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cubes(int N)
{
    int current = 1;
    while(current <= N)
        {
            Console.Write(current * current * current + " ");
            current++;
        }
} 

int N, checkNumber;
Console.Write("Введите целое число: ");
checkNumber = Convert.ToInt32(Console.ReadLine());
if(checkNumber < 0) N = checkNumber * (-1);
else N = checkNumber;
Console.WriteLine($"Таблица кубов чисел от 1 до {N}");
Cubes(N);
