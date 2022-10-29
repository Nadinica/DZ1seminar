// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int a = 2;
int b = 3;
int c = 7;
int max = a;

int a1 = 44;
int b1 = 5;
int c1 = 78;
int max1 = a1;

int a2 = 22;
int b2 = 3;
int c2 = 9;
int max2 = a2;

max = NewMethod(b, c, max);
Console.Write("max = ");
Console.WriteLine(max);

static int NewMethod(int b, int c, int max)
{
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}

max1 = NewMethod1(b1, c1, max1);
Console.Write("max1 = ");
Console.WriteLine(max1);

static int NewMethod1(int b1, int c1, int max1)
{
    if (b1 > max1) max1 = b1;
    if (c1 > max1) max1 = c1;
    return max1;
}

max2 = NewMethod2(b2, c2, max2);
Console.Write("max2 = ");
Console.WriteLine(max2);

static int NewMethod2(int b2, int c2, int max2)
{
    if (b2 > max2) max2 = b2;
    if (c2 > max2) max2 = c2;
    return max2;
}