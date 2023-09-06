// Console.WriteLine("Home work seminar 9 - Рекурсия! ");

/* Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// Примеры:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");  // Вывод информ на консоль
int number = Convert.ToInt32(Console.ReadLine()); // объяв перем number
int count = 1; // Объяв перем count, котор присв 1
NaturalToLow(number, count); // Объяв функц NaturalToLow (натуральные числа),
                             // в аргум добавл (number, count);

void NaturalToLow(int n, int count) // прим войд метод, в арг добав наше знач, и N count
{
    if (count > n) // Если count > n
       return; // возвращ результат
    else // Иначе, выполн операции в фигурн скобках
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// Примеры:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Запросим данные у пользователя
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n); // Сумма натур элем от M до N

// Вызов функции "сумма натур элем от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// Функция сумма натур элементов от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}
// Функция Аккермана
// A(m, n) определяется для всех неотрицательных целых
// аргументов m и n следуюзим образом: 
// A(m, n) = Действия в фигурных скобках:
int Akkerman(int m, int n)  
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

