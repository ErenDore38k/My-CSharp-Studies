//C# 7.0 Pattern Matching - Recursive Pattern

/*Bu desen switch- case yapılanması üzerinde birçok yenilik getirmektedir.
 *Switch bloğunda referans türlü değişkenlerde kontrol edilebilmektedir öncesinde switch bloğunda sadece değer türlü değişkenler kullanılabil
 *mekteydi. 
 *Ayrıca switch bloğuna when komutu ile çeşitli şart / koşul niteliği kazandırılmıştır.
 *Recursive Pattern tür kontrolü yaptığı için Type Patternı kapsamaktadır.
 *Recursive Pattern , case null komutu ile ilgili türün/referansın null olup olmamasını kontrol edebilmesinden dolayı Constant PAtternı
 *kapsamaktadır.
 *Recursive Pattern switch'i daha esnek hale getiren patterndır.
 */

//Type Pattern ve Var Pattern ı illa da akış kontrol mekanizmaları üzerinde kontrol etme gibi bir zorunluluğumuz yok. Onlar olmadan da 
//kullanabiliriz.

object x = "tvr";
if (x is string r) // Type Pattern kullanımı 
{

}
if (x is var u) // Var Pattern kullanımı 
{

}
object m = "Thy";
bool result = m is string o;

//İf ile kullanım yaparsak null olma ihtimalini ortadan kaldırmış olurum. 
//İf ile kullanım yapmak daha kullanışlıdır. 
//İf ile kullanım yaparsak kesinlikle yazdırma işlemi yapabiliriz false olsa bile.


//C# 9.0 Pattern Matching Enhancements

//4 Tane C# 9.0 ile geliştirilmiş patternımız var. 
//Öğrendiğimiz pattern’ların C# 9.0 ile geliştirilmesidir.


/*
 *Simple Type Pattern bir değişken içerisindeki değerin belirli bir türde olup olmadığını hızlı bir şekilde kontrol etmemizi sağlayan desendir.
 *C# 9.0'dan önce Type Pattern ile yapılan tür bildirimlerinin yanına değişken adı tanımlaması yahut discard ifadesinin kullanılması
 *zaruriydi .C# 9.0 ile bu gereksiz zorunluluk ortadan kaldırılmış ve direkt olarak tür kontrol işlemine odaklanılması sağlanmıştır.
*/


/*
 *Relational Pattern desenlerde <, >, <=, >= operatörlerini kullanabilmekte ve belirli karşılaştırmalar hızlıca gerçekleşebilmektedir.
 *Switch özü itibariyle sadece eşitlik durumunu inceleyen bir akış kontrol şemasıydııııı. Relational Pattern ile diğer türlü
 *karşılaştırmalarıda yapabilmekteyiz.
 */

/*
 *C# 9.0 dan önce Switch ve if arasında ki fark şöyle idi : Switch ile eşitlik durumunu kontrol ederken if ile her türlü kontrolleri 
 *yapabiliyoruz.Ama C# 9.0 ile gelen Relational Pattern sayesinde Switch ile de her türlü kontrolleri yapabilmekteyiz.
 */

/*Logical Patternand,or ve not gibi mantıksal operatörleri programlamaya kazandıran bir desendir.
* Relational Pattern ile oldukça uyumludur.
*/

//Not Pattern not operatörünün kullanılabilidiği bir desendir.



