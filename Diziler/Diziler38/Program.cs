//Düzensiz Diziler Nedir?
/*
 *Düzensiz dizi; her bir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
*Çok boyutlu dizilerden tek farkı, çok boyutlu dizilerin sütün sayılarının sabit, halbuki düzensiz dizilerin ise sütün
*sayılarının değişken olmasıdır.
*/


// Düzensiz Dizi Tanımlama

int[][] Sayilar = new int[3][];
Sayilar[0] = new int[3] { 2, 4, 6 };
Sayilar[1] = new int[5] { 3, 6, 9, 12, 15 };
Sayilar[2] = new int[2] { 36, 38 };



//Düzensiz Diziler - Değer Atama/Değer Okuma

int[][] sayilar = new int[3][];
sayilar[0] = new int[3] { 2, 4, 6 };
sayilar[1] = new int[5] { 3, 6, 9, 12, 15 };
sayilar[2] = new int[2] { 36, 38 };
Console.WriteLine(sayilar[0][0]);
Console.WriteLine(sayilar[2][1]);