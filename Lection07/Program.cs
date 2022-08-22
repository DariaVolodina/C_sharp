// РЕКУРСИЯ - это функция, которая вызывает сама себя.
//Самое выжное при описании рекурсии - описать условие ВЫХОДА!

//Собрать строку с числами от А до В, а <= b
/*
//ИТЕРАТИВНЫЙ МЕТОД - многократное повторение

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

//РЕКУРСИВНЫЙ МЕТОД

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


//сумма чисел от 1 до n
int SumFor (int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;

    return result;
}
int SumRec (int n)
{
    if (n == 0) return 0;
    else return n + SumRec (n-1);
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55


//Факториал числа
int FactorialFor(int n)
{
    int result = 1; 
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800


string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a}" + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


//Возведение числа в натуральную степень
int PowerFor (int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec (int a, int n)
{   //return n == 0 ? 1: PowerRec (a, n - 1) * a:
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a, n - 1) * a;
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024


//Перебор слов 
//В некотором машинном алфавите имеются 4 буквы А, И, С и В. Покажите все слова, состоящие из Т букв, 
//которые можно построить из букв этого алфавита. 
char[] s = { 'a', 'i', 's', 'b'};
int count = s.Length;
int n = 1;
for (int i = 0; i< count; i++) //если 4-буквенные слова, то будет 4 цикла... и т д . Цикл в цикле в цикле .....
    for (int j = 0; j < count; j++)
        for (int k = 0; k < count; k++)
            Console.WriteLine($"{n++, -5}{s[i]}{s[j]}{s[k]}"); 

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length) //  УСЛОВИЕ ВЫХОДА ИЗ РЕКУРСИИ
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("esta", new char[3]);


//DirectoryInfo - класс для работы с директориями
string path = "аадрес папки";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

цикл... пробежаться по всей папке (по всему массиву)

void CatalogInfo(string path, string indent = "") //1ый аргумент - путь к текущей папке. 2ой - искусственный приём, чтобы делать отступы
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent} {catalogs[i].Name}");  
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = CatalogInfo.GetFiles();

    for (int i = 0; i < files.Length; i++)
        Console.WriteLine($"{indent} {files[i].Name}");
}

string path = @"folder adress";
CatalogInfo(path);
*/

//Игра в пирамидки / Генуэзские башенки
void Towers(string with = "1", string on = "3", string some = "2", int count = 3) 
// 1-шпиль, на которой блинчики, 3 - куда и надо переместить, 2-доп, count - количество блинчиков
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

//МИНУСЫ РЕКУРСИИ
//долгий подсчет (например, при подсчете чисел Фиббоначи)
