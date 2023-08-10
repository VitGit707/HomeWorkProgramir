/*Task 10. Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
Примеры
456 -> 5   
782 -> 8   
918 -> 1 

Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
*/

/*Task 13: Напишите программу, которая выводит третью цифру заданного 
числа ( или -1, если третьей цифры нет).
Примеры:  
645 -> 5    
78 -> третьей цифры нет   
32679 -> 6

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
    Console.WriteLine("Третья цифра -> " + anyNumberText[2]);
else
    Console.WriteLine("-> третьей цифры нет");
*/

/*
Task 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
Примеры:
6 -> да   
7 -> да  
1 -> нет
*/

/*Для начала создадим на будущее метод, который позволит
// выводить приглашения к вводу числа, преобразовывать
// введённую строку в число, и присваивать это число разным
// переменным

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// Создадим метод, который вернёт для выходного дня
// значение «истина» (true), а для рабочего «ложь» (false).

bool Isweekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

// Запрашиваем и получаем день недели (его номер).


bool ValidateWeekday (int number)

// Проверяем, является ли введённая цифра днём недели.
// Если нет, то сообщаем об этом пользователю и повторяем
// приглашение.
{
    if (number > 0 && number <= 7)
    {
      return true;
    }
    Console.WriteLine("Это не день недели!");
      return false;
}

// Если попали в пределы недели можно выводить,
// будет ли пользователь отдыхать в этот день.

int weekDay = Promt("Введите день недели >");
if (ValidateWeekday(weekDay))

    if (Isweekend(weekDay))
    {
    Console.WriteLine("Сегодня выходной! Работать вредно!");
    }
    else
    {
    Console.WriteLine("Вам на работу!");
    }