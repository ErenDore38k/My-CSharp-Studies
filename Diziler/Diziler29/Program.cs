//(C# 8.0)Ranges and Indices ^ Operatörü

/*
 * ^ Operatörü: Veri kümelerinde index değerinin tersini ifade eder. 
 *Normal index yapılanmasına nazaran ters index durumu 0'dan değil 1'den başlamaktadır.
 *Örnek kullanımı : string isim = isimler[^3]; şeklindedir.
 *Genellikle bir dizinin son elemanına erişmek için kullandığımız karışık manevrasal algoritmalardan bizleri kurtarmaktadır.
 */



//(C# 8.0)Ranges and Indices ^ Operatörü İnceleme
// ^ Bu operatörü kullanabilmek için index türünde çalışılması gerekmektedir. Çünkü bu operatör geriye index türü döndürür.

int[] Sayılar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Index i = ^3;
Console.WriteLine(Sayılar[i]);
Range range = ^7..^3;


