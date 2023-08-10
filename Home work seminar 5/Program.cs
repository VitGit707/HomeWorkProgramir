// Home work seminar 5
// Console.WriteLine("Home work seminar 5!");

/* Task 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Примеры:
// [345, 897, 568, 234] -> 2

// Программа должна показывать массив, заполненный случайными положительными трёхзначными
//  числами,  и должна расчитывать количество четных чисел в этом массиве 

// ===== Решение

Console.Write("Введите размер массива: "); // вывод данн о разм массива;
int size = Convert.ToInt32(Console.ReadLine()); // присв перем int разм масс 
int[] numbers = new int[size]; // выдел память под массив. Опишем, что в нем будет 
// столько-то элементов в нашем случае [size]
FillArrayRandomNumbers(numbers); // Заполн многомер массив случайнымиыли числами
Console.WriteLine("А вот и наш массив: "); // Выз конс вывод данных с перех на нов строку
PrintArray(numbers);  // печатаем массив
int count = 0;  // интов перем count, присвоим ей 0 значение

for (int z = 0; z < numbers.Length; z++) // заполн цикл for
if (numbers[z] % 2 == 0) // провер все чис масс, и четные (делящ на 2 без остатка суммир)
count++;  // Счетчик, провер все числа в массиве

Console.WriteLine($"Состоит из {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers) // метод void
{
    for(int i = 0; i < numbers.Length; i++) // Прогоним станд цикл for
    {
        numbers[i] = new Random().Next(100,1000); //Рандом методом возвр случ цел чис в указ диапаз
    }
}
void PrintArray(int[] numbers) // Печат наш массив
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]"); // Выводим
    Console.WriteLine();// Выводим пустую строку
}
*/


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Примеры:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Программа дожна отображать одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("А вот и наш массив случайных чисел: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Примеры:
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Программа должна отображать массив вещественных (дробных) чисел double (Например: 3.22, 1.15,
// 65.2 и т.д), и находить разницу между максимальным и минимальным элеменом массива

Console.WriteLine("Введите размер массива"); // вывод данн о разм массива;
int size = Convert.ToInt32(Console.ReadLine()); // присв перем int разм масс
double[] numbers = new double[size]; // выдел память под масс double. Опишем, что в нем 
// будет столько то чиесл, в нашем случае size
FillArrayRandomNumbers(numbers); // Заполн многомер массив случайными числами
Console.WriteLine("Вот наш массив: "); // вывод данн о разм массива;
PrintArray(numbers); // распечат массив
double min = Int32.MaxValue; // min перем double
double max = Int32.MinValue; // max перем double

for (int z = 0; z < numbers.Length; z++)  // пров станд цикл for 
// (пер int я присв 0, пока z < разм массив, став счетч проходим по всем элем массива)
{  
    if (numbers[z] > max) // если тек перем > max
        {
            max = numbers[z];  // тогда max знач присв этой перем
        }
    if (numbers[z] < min) // если тек перем  < min
        {
            min = numbers[z]; // тогда min знач присв этой перем
        }
}
 
Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers) // метод void
{
    for(int i = 0; i < numbers.Length; i++) // Прогоним станд цикл for
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100; //Рандом методом возвр случ цел чис в указ диапаз
        }
}
void PrintArray(double[] numbers)  // выводим на печать наш массив
{
    Console.Write("[ "); // Выводим
    for(int i = 0; i < numbers.Length; i++)  // Прогоним станд цикл for
        {
            Console.Write(numbers[i] + " "); // Вывод, прох по всем элем массива
        }
    Console.Write("]"); // Выводим
    Console.WriteLine();// Выводим пустую строку
}
