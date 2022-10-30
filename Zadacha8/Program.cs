// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Even (int [] number)
{
    int n = 5;
    int index = 0;
    int even = 0;
    while (number[index] < n)
    {
        int result = number[0];
        if (number[index] % 2 == 0);
        return result;
    }
    index++;
 }

int[] number = { 1, 2, 3, 4, 5 };

int even = Even(number);
Console.WriteLine(even);

