// Напишите программу, которая перевернёт 
//одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

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

int[] ReverseAray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)//первый блок в цикле ФОР отвечает за инициализацию счётчикаб последний блок - за изменение индекса
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    return array;
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

// как сгенерировать случайное вещественное число. Можно отдельно сгенерировать его целую часть и его дробную часть
//double number = new Random().Next(1,10) + new Random().NextDouble();
//а можно создать объект РАНДОМ. С№ - объектно-ориентированный ЯП
//вместо того, чтобы рандом не вызывать каждый раз
Random rand = new Random();
double number = rand.Next(1,10) + rand.NextDouble();


//Напишите программу, которая принимает на вход три числа и 
//проверяет, может ли существовать треугольник с сторонами такой длины. 
//(каждая из сторон должна быть строго меньше, чем сумма двух других) a d c   a < b + c

bool Len(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}

Console.Write("Введите длину a: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину b: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину c: ");
int C = Convert.ToInt32(Console.ReadLine());

bool f = Len(A, B, C);
Console.WriteLine(f);

//Напишите программу, которая будет преобразовывать десятичное число в двоичное. int на вход выход массив строковый

string Conv(int N)
{
    string result = String.Empty;
    while(N > 0)
    {
        result = N % 2 + result;
        N /= 2; 
    }

    return result;
}

Console.Write("Введите N: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат =  {Conv(num)}");

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//первые два числа должны прийти извне (три аргумента)

// 0, 1, 1 , 2, 3, 5, 8, 13  N = (N - 1) + (N - 2)
// 2 , 3  N = 5
string fib(int N, int x1, int x2)
{
    string result = ($"{x1} {x2}");
    for(int i = 2; i < N; i++)
    {
        int x3 = x1 + x2;
        result = ($"{result} {x3}");
        x1 = x2;
        x2 = x3;
    }
    
    return result;
}

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 1 элемент: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 элемент: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат: {fib(n, x1, x2)}");

*/

//то же через МАССИВ

int[] Fibanacci(int size, int a, int b)
{
    int result = new int[size];
    result[0] = a;
    result[1] = b;

    for(int i = 2; i < size; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    
    return result;
}

ShowArray(Fibanacci(5, 1, 2));





