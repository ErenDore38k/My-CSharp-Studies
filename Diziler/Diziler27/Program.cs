//(C# 8.0)Ranges and Indices - System.Range İnceleme 2

/*
int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Range range = 5..^3;
var sayilar2 = sayilar[range];
*/

int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Range range = ^5..^3;
var sayilar2 = sayilar[range];
Index i = ^1;
Console.WriteLine(sayilar[i]);