﻿Console.Clear();
int m = 1;
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
for(int i = m; i <= n; i++)
{
    if(i%2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();