﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int[] array = { 4,-3, 7 };

int n = array.Length;
int index = 0;
while (index < n)
{
    if (array[index]%2==0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    index++;
}



