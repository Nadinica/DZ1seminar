// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

double a = 2;
double b = 10;
double max = a;
double a1 = -9;
double b1 = -3;
double max1 = a1;
if (b > max) max = b;
if (b1 > max1) max1 = b1;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("max- = ");
Console.WriteLine(max1);
