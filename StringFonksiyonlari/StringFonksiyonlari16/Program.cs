//String Fonksiyonları - Compare Metodu

//Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int türde değer elde etmemizi sağlar.
// 0 : Her iki değer birbirine eşittir.
// 1 : Soldaki sağdakinden alfanumerik olarak büyüktür.
// -1 : Soldaki sağdakinden alfanumerik olarak küçüktür.

string metin = " adana";
Console.WriteLine(string.Compare(metin, "Şanlı"));
