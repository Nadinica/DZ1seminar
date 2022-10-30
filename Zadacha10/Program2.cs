
int[] x = { 456, 782, 918 };
int n = x.Length;
int index = 0;
while (index < n)
{
    a = x / 10;
    b = a % 10;
    index++;
    return b;
}

Console.Write("456 -> ");
Console.WriteLine(b);
Console.Write("782 -> ");
Console.WriteLine(b);
Console.Write("918 -> ");
Console.WriteLine(b);
