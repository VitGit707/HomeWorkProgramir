/*Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
Примеры
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
 /*Program
Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Max = " + num1);
}
else
{
    Console.WriteLine("Max = " + num2);
}
*/ 

/*Task 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
Примеры:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*Program

Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
    max = num2;

if (num3 > max)
    max = num3;
        
Console.WriteLine("max = " + max);
*/

/*Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли
число чётным (делится ли оно на два без остатка).
Примеры:
4 -> да
-3 -> нет
7 -> нет

/*Program

Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if  (num % 2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
/*

/*
Task 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
Примеры:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
//Program

Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if (current % 2 == 0) Console.Write(current + " ");
    current++;
}