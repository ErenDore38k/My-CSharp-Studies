
//Is Null Operatörü
//Bir değişkenin değerinin null olup olmamasını kontrol eden ve sonuç olarak geriye bool türde bir değer döndüren operatördür.

string s = " Naber ";
Console.WriteLine(s is null);

//Yukarıda vermiş olduğum örnekteki gibi bir kullanım yapabiliriz. Yukarıda vermiş olduğum örnekte s nin değeri null 
//olmadığındand dolayı bize false değerini ekrana çıktı olarak verecektir
////is null operatörünü sadece null olabilen türlerde kullanabilmekteyiz.
//DEğer türülü değişkenlere null değerini veremeyiz ama referans türlü değişkenlere null değerini verebiliriz. örn string de 
//olduğu gibi.Değer türlü değişkenlere null değerini verememe sebebimiz değer türlü değişkenlerin default yani varsayılan
//değerlerinin olması nedeniyle. 


//Is Not Null Operatörü
//Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuç döndürmektedir. 
//Elimizde ki değerin null olmaması durumunda true değerini döndürür . Elimizdeki değer null ise false değerini döndürür. 
//İS null ile tersi mantıkda çalılmaktadır . Sadece null alabilen türlerde kullanılabilir. 
//İS null da olduğu gibi buradada sadece referans türlü değerlerde çalışma durumu geçerlidir. 
