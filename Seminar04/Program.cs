/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int NumOfDigits(int num)
{
    int count = 0;

    while(num != 0) // если написать num > 0, то будет выдаваться ошибка в случае ввода ОТРИЦАТЕЛЬНОГО числа
    {
        num /= 10; //целочисленное делениe, то же самое, что num = num / 10
        count++;
    } 

    return count;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);//int numOfDigits = NumOfDigits(number);
Console.WriteLine($"Number of Digits of { number } is { result }"); //Console.WriteLine($"Number of Digits of { number } is { numOfDigits }")

// цикл for(int i = 0, i < number && i % 7 == 0; i++, j++) - в основном используется при работе с массивами. 


// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.


int SumDigits(int num)
{
    int sum = 0, count = 1;

    while(count <= num)
    {
        sum = count + sum;
        count++;
    }
    return sum;

}
Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);
Console.WriteLine($"Sum of numbers from 1 to { number } is {result} ");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N, кратных трем.


int MultNum(int num)
{
 int result = 1;
 for(int i = 3; i <= num; i+=3)
 {
    result *= i;
 }
 return result;
} 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 3) Console.WriteLine("Число меньше 3");
else
{
    int result = MultNum(number);

    Console.WriteLine($"Произведение сисел от 1 до { number }, кратных 3, равно {result}");
}

/*
задача с массивом_УНИВЕРСАЛЬНАЯ запись!: 
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.  
*/

int[] CreateRandomArray(int size, int minValue, int maxValue) //размер массива, диапазон
{
    int[] newArray = new int[size]; //шаблон выделения памяти под массив. . команда new - выделяет память. Создали объект newArray, типа инт. и под него выделили память. 

    for(int i = 0; i < size; i++) //i отвечает за индекс
        {
            newArray[i] = new Random().Next(minValue, maxValue +1);// генерирует случайное целое число от нижней границы, вкл ее, до верхней границы, НЕ ВКЛЮЧАЯ ее
        }
    return newArray;
}

void ShowArray(int[] array) // единственная его задача выкинуть но, что в него ввели, поэтому войдовский метод
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int [] binaryArray = CreateRandomArray(8, 0, 1);
ShowArray(binaryArray);


