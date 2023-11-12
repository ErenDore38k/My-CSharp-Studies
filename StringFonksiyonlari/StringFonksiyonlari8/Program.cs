//String Değerlerde (Escape)Kaçış Karakterleri

/* 
 *Kaçış karakterleri ve görevleri : 
 *  \o : Null sonlandırma karakteridir.Genel olarak dosya veya veri kanalının bitişini belirtmek için kullanılır. 
 *  \a : Bip sesini çıkartan karakterdir.
 *  \b : BackSpace-Geri-Önceki karakteri silme. 2 kere yazıp kullanacağız.
 *  \t : Tab
 *  \r : Satır Başı (Carriage Return).
 *  \n : Bir alt satıra iner(Sıklıkla kullanırız)  .
 *  \v : Dikey tab.
 *  \f : Sayfa ilerleme.
 *  \"" : Çift tırnak.
 *  \': Tek Tırnak.
 *  \ : BackSlash. 
 *  
 *  " Tırnak : Eylemsel bir karakter. String açısından belirli bir operasyonu/eylemi/sorumluluğu üstlenen bir karakterdir. Dola
 * yısıyla böyle bir karakteri metnin içerisinde salt bir şekilde kullanmamız mümkün değildir.
 * 
 * String içerisinde kaçış karakteri olarak \(Backward Slash) kullanılmaktadır. String içerisinde özel/operatif karakterleri 
 * ezen ve bunları metinsel hale getirmemizi sağlayan bir karakterdir.
 */

//Console.WriteLine("\"Bugün hava çok güzel\"");
//Backward Slash Kendisinden sonra gelen karakterin bir özel/eylemsel/operatif karakter olmadığını, metinsel bir değer olduğunu
//ifade eder.
//Backwars Slash yanına illaki özel bir karakter/eylemsel bir karakter bekler.Aksi takdirde hata verir.
//MEtinsel olarak \kullanmak istiyorsak eğer ilgili operatörü yine kendisiyle ezmeliyiz.Örn 
//Console.WriteLine("Eren\\Döre"); Şeklinde olmak üzere.

// \a örneği :    Console.WriteLine("Mauro İcardi\a");
// \t kullanım örneği Console.WriteLine(" Kayseri\tTrabzon");

Console.WriteLine("Ne dedi\n");