﻿//Баранович Артур
//4.Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
//а) с использованием третьей переменной;
//б) *без использования третьей переменной.

Console.WriteLine("Присвойте значение А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Присвойте значение B");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
a = b;
b = c;
Console.WriteLine("Значение А - " + a + "Значение B - " + b);

//поменяем их в обратную сторону без 3 переменной 

a = a + b;
b = a - b;
a = a - b;
Console.WriteLine("Значение А - " + a + "Значение B - " + b);
