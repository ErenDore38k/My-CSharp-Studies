//(C# 8.0)Ranges and Indices - System.Range Türü

/*System.Range Türü : Veri kümelerinde hangi değerler ile çalışacağımızı belirleyebilmek için index üzerinden aralık vermemizi 
 *ve bunu .. operatörü ile gerçekleştirmemizi sağlayan yapılanmadır.
 * .. operatörü hedeflenen aralığı bizlere Range türünde geri getirecektir.Böylece biz ilgili aralığı bir diziymiş gibi
 *kulllanabileceğiz.
 *.. operatörünün solundaki değer index değerini, sağındaki değer ise sıra numarasını ifade etmektedir.
 *indexer[] operatörü içerisine tam sayı veya index türü verilebildiği gibi Range türüde verilebilir.
 */



//(C# 8.0)Ranges and Indices - System.Range İnceleme 1

/*
int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Range range = 5..10;
var sayilar2 = sayilar[range];
*/

int[] sayilar = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
Range range = ..; // Tüm diziye karşılık gelir.
                  // .. Operatörünü sayısal değerler olmadan kullanırsanız ilgili diziyi topyekün kopyalar ve geriye döndürür.
Index i = ^4;
Console.WriteLine(sayilar[i]);