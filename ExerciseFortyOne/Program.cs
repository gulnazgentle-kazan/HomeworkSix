﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Ввод чисел останавливается при помощи ввода стоп-слова "stop" и 
производится при помощи нажатия Enter

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/


int number;
int count = 0;
string answer = null;
string stop = "stop";
Console.WriteLine("Введите любое число, или слово stop, чтобы выйти из программы");
while (true)
{
    answer = Console.ReadLine();
    if (answer == stop)
    {
        break;
    }
    number = Convert.ToInt32(answer);
    if (number > 0) count++;
}

Console.WriteLine(count);