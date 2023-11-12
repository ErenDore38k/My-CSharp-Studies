//String Fonksiyonları - CompareTo Metodu

//Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int türde değer elde etmemizi sağlar.
// 0 : Her iki değer birbirine eşittir.
// 1 : Soldaki sağdakinden alfanumerik olarak büyüktür.
// -1 : Soldaki sağdakinden alfanumerik olarak küçüktür.

string metin = "Giresun";
Console.WriteLine(metin.CompareTo("A"));
Console.WriteLine(metin.CompareTo("G"));
Console.WriteLine(metin.CompareTo("Giresun"));
Console.WriteLine(metin.CompareTo("Zobor"));
Console.WriteLine(metin.CompareTo("Hakkari"));