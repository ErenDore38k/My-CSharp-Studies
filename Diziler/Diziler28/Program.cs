// (C# 8.0)Ranges and Indices .. Operatörü

/* 
 * .. Operatörü : Veri kümelerinde belirli bir aralığı temsil eden operatördür.
 *Aralık operatörü diyede isimlendirilebilir.
 * .. Operatörü sağına ve soluna sayısal bir değer alabildiği gibi özü itibariyle System.Index türünden de değerler alabilir.
 *Geriye System.Range türünden yapı döndürür.
 */



//(C# 8.0)Ranges and Indices .. Operatörü İnceleme

int[] Sayılar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Index i1 = 5, i2 = 10;
Range range = i1..i2;
var sayilar2 = Sayılar[range];

Index i = ^3;
Console.WriteLine(Sayılar[i]);


