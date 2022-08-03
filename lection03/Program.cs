// 1 вид методов
/*
void Method1()
{
    Console.WriteLine("Athor ...");
}
Method1();//скобки обязательно!

// 2 вид методов
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Text", count: 4); //или ("Text", 4)4 раза хочу увидеть это сообщение
Method21(count: 4, msg: "New text");//не обязат по порядку, если аргументы именованы

// 3 вид методов, что-то возвращают, но ничего не принимают
int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// 4 вид методов - что-то принимают и возвращают
string Method4(int count, string text)//возвращать будем строку 
{
    int i = 0;
    string result = String.Empty;//""

    while (i < count)
    {
        result = result + text;
        count++;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

//ЦИКЛЫ и не только
//цикл со счётчиком FOR. синтаксически всё собирает в кучу
string Method41(int count, string text)//возвращать будем строку 
{
    string result = String.Empty;

    for (int i = 0; i < count; count++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

//цикл в цикле
//Задача вывода таблицы умножения на экран

for (int i = 0; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();//разрыв - пустая строка
}
*/

//решение задачи по замене символов внутри данного текста
/* Дан текст. В тексте нужно все пробелы заменить черточками, 
маленькие буква "к" заменить большими "К",
а большие "С" заменить меленькими "с".


string text = "- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty"
//            0123
// s[3]    //r  

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;//получаем длину строки - команда для получения кол-ва символов в строке
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";//если в тексте и-тая совпадает с символом, который мы хотим заменить, то в результат мы положим новое значение
        else result = result + $"{text[i]}"; //если совпадений нет, то в резалт добавляем текущий символ, который и был
    }

    return result;
}

string newText = Replace(text, ' ', '|');//показываем что на что заменить
Console.WriteLine(newText);
Console.WriteLine();//пустая строка

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();//пустая строка

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/

// МАССИВЫ!!!!! сортировка от мин до макс

int [] arr = { 1, 5, 2, 4, 3, 2, 2, 2, 6, 7};

void PrintArray(int [] array)// метод, который решает задачу ВЫВОДА массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)//метод, который будет упорядочивать наш массив
{
    for (int i = 0; i < array.Length; i++)//нам надо пробежаться по всем элементам массива, array.Length - обращение к длине массива
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length - 1; j++)//ищем максимальный элемент пользуемся циклом внутри цикла
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];//меняем позиции!!! с индексом i - наша рабочая позиция. темп будет временным хранилищем
        array[i] = array[minPosition];//туда мы положим элемент, написанный выше
        array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);