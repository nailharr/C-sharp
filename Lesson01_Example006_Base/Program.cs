﻿int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 3;
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("maximum -> ");
Console.WriteLine(max);