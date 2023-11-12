//String Türlerde @(Verbatim Strings) Operatörü

//3 tane kullanım amacı vardır. 


//String Türlerde @(Verbatim Strings) Operatörü Kullanım Durumu 1

//Bir değişken yahut metot vs gibi yapılanma isimlerinin programatik bir keyworde karşılık gelmesi mümkün değildir.
//derleyici hatası verir.
//Eğer ki illa ben bir keyword ismi kullanacam diyorsan eğer @ operatörünü kullanabilirsin. 
//int @string = 1901;
//double @double = 74.36;



//String Türlerde @(Verbatim Strings) Operatörü Kullanım Durumu 2

//Escape karakterlerinin kullanılması icap eden durumlarda @ operatörünü kullanarak eylemsel karakterleri kendileriyle 
//ezebilecek özellik kazandırabiliyoruz.

string metin = @"Hava bugün ""soğuk """;
Console.WriteLine(metin);
