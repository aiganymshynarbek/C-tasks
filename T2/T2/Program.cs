﻿Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i+" ");
    }
}

if (N < 1)
{
    Console.WriteLine("Число должно быть больше 0");
}