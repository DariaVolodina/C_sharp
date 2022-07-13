/*задача с гирьками
int a = 1;
int b = 2; 
int c = 6;
int d = 8;
int e = 4;

int max = a;

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);


Увлекательная задача про точки:
Алгоритм: 
1. Определить три точки
2. Выбрать две любые
3. Найти середину
4. Поставить точку
5. Выбрать случайную вершину треугольника
6. Соединить её с полученной на 4 шаге точкой
7. Перейти к шагу 3
8. Шаги 3 - 7 повторить 9, 28, 31 раз
*/ 

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y= xb;
int count = 0;

while(count < 1000)
{
    int what = new Random().Next(0, 3); //[0;3] 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}




