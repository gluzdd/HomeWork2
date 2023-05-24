/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1


Console.WriteLine("Ввеlите трёхзначное число: ");
int Numberthree = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Numberthree);
Console.WriteLine("Вторая цифра трёхзначного числа " + stringNumber[1]);

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


Console.WriteLine("Введите число: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
string stringNumberN = Convert.ToString(NumberN);
if (stringNumberN.Length > 2)
{
    Console.WriteLine("Третье число " + stringNumberN[2]);
}
else
{
    Console.WriteLine(" - Третьего числа нет");
}


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


Console.WriteLine("Введите цифру дня недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber < 8)
{
    if (dayNumber < 6)
    {
        Console.WriteLine("Этот день считается рабочим " + dayNumber);
    }
    else if (dayNumber > 5)
    {
        Console.WriteLine("Этот день считается выходным " + dayNumber);
    }
}
else
{
    Console.WriteLine("Этот день не считается днём недели " + dayNumber);
}


*/