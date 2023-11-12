//StringSegment Türü Nedir?

//StringSegment, ArraySegment'in string değerler neznindeki bir muadilidir.
//Esasında metinsel değerlerdeki birçok analitik operasyonlardan bizleri kurtarmakta ve Substring vs gibi fonksiyonlar yerine
//string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.





//StringSegment Türü İle Dizinin Belli Bir Alanını Referans Etmek

//StringSegmetn türünü kullanabilmek için uygulamaya Microsoft.Extensions.Primitives paketinin yüklenmesi gerekmektedir.

/*
using Microsoft.Extensions.Primitives;

string metin = "Ölüme gidelim dedin de mazot mu yok dedik.";
StringSegment segment = new StringSegment(metin);
StringSegment segment1 = new StringSegment(metin, 2, 5);
Console.WriteLine(segment1);
*/





//StringBuilder Sınıfı Nedir? Ne Amaçla Kullanılır?

//StringBuilder string birleştirme operasyonlarında +operatörüne nazaran yüksek maliyeti absorbe edebilmek için arkaplanda 
//StringSegment algoritmasını kullanan ve bu algoritma ile bizlere ilgili değerleri olabilecek en az maliyetle birleştirip 
//döndüren bir sınıftır.

using System.Text;

string isim = "Eren";
string soyisim = "Döre";
//Console.WriteLine(isim + " "+ soyisim); // şeklinde yapılır ancak maliyet açısından StringBuilder Sınıfını kullanmak gerekir.

StringBuilder builder = new StringBuilder();
builder.Append(isim);
builder.Append("  ");
builder.Append(soyisim);
Console.WriteLine(builder.ToString());