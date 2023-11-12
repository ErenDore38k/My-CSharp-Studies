//TimeSpan Türü İle İki Tarih Farkının Karşılanması

//İki tarih arasındaki farkı aldığımızda sonuç olarak TimeSpan döndürecektir ve TimeSpan olarak karşılayabilmekteyiz.
//Erişim belirleyici ile de TimeSpan fonksiyonlarına vs. ulaşılmaktadır.


DateTime T1 = DateTime.Now;
DateTime T2 = new DateTime(2004, 3, 16);
TimeSpan span = T1 - T2;
Console.WriteLine(span.Days);