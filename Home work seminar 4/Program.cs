// Урок 4. Функции
/* Task 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Примеры
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* Решение: Метод void
Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

  void GetDegree(int A, int B)
{
    int res = 1;
    for (int i = 0; i < B; i++)
    {
        res *= A;
    }
    Console.WriteLine($"{A}, {B} -> {res}");
}
Console.Write("Your base num: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Your degree num: ");
int B = Convert.ToInt32(Console.ReadLine());
GetDegree(A, B);
*/

/* Task 25: 2-ой Вариант решения: Через Math Pow

Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

void  GetDegree(int a, int b)
{
     if (b > 0)
     {
       int result = (int)(Math.Pow(a, b));
       Console.WriteLine(result);
     }
     else Console.WriteLine("Wrong meaning of " + b);
}

Console.WriteLine("Введите число, которое будете возводить в степень: ");
int baseA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение натуральной степени: ");
int powA = Convert.ToInt32(Console.ReadLine());

GetDegree(baseA, powA);
*/

/* Task 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// Примеры:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine($"\nЗадача 27. Сумма цифр во вводимом числе");

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
*/

// Task 29: Напишите программу, которая задаёт массив из m элементов и 
// выводит их на экран.
// Примеры:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/* Первый вариант решения:
// С примененем метода Генерация случайных чисел (random next), и 
// указанием Минимального int valMin и Максимального int valMax значения массива. 

int[] CreateArr(int m, int valMin, int valMax)
{
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = new Random().Next(valMin, valMax + 1);
    }
    return arr;
}
void WriteArr(int[] arr)
{
    Console.Write(arr[0]);
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write($" - > [{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", {arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Your m: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value min: ");
int valMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Your value max: ");
int valMax = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArr(n, valMin, valMax);
WriteArr(myArray);
*/

// Второй вариант решения:
// С примененем метода Генерация случайных чисел (random next), и 
// без указания Минимального и Максимального значения массива. 

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}