// Home work seminar 3

// Task 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//Примеры
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
bool Palidrom(string numbers)
{
    int i = 0;
    int len = numbers.Length;
    while (i < len/2) 
    {
        if (numbers[i] != numbers [len - i -1]) return false;
    i++;
    }
return true;
}

Console.WriteLine("Input a number: ");
string number = Console.ReadLine();

bool res = Palidrom(number);

if(res == true) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");
*/

/* Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// Примеры
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double deltaX = x2 - x1;
    double deltaY = y2 - y1;
    double deltaZ = z2 - z1;
    return Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
}

Console.Write("Введите координаты х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние составит {0:f2}", Distance3D (x1, y1, z1, x2, y2, z2));
*/

/* Task 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// Примеры
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void WriteCube(int number)
{
    int current = 1;
    while (current <= number)
    {
            Console.WriteLine(Math.Pow(current, 3));
            current++;
    }
}
Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteCube (number);
*/
