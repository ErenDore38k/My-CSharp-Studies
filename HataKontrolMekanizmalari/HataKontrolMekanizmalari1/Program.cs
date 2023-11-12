//Hata Kontrol Mekanizmaları Nedir? Ne Amaçla Kullanılır?

/*Bu konu önemli bir konudur. Bu komuyu bitirdikten sonra hataları daha kolay ve daha düşük bir tansiyon ile ele alacağız.
 Yazılımcı hata yapabilir bunun kadar doğal bir şey yok ama yazılımcı da o hataları da çözebilir. Bir yazılımcı hata yapınca
 moreli bozulmamalı.
*/


//Hata Türleri - Derleme/Syntax/Sözdizimi Hatası

/*Program dili kurallarına aykırı olan hatalardır.
 *Özellikle gelişmiş editörler(VS) sayesinde söz dizimi hataları derlemeye gerek bile kalmaksızın fark edilebilmektedir.
 *Hatanın bulunduğu satır derleyici tarafından rapor edilir.
 *O yüzden fark edilmesi ve çözülmesi en kolay hata türüdür.
 */


//Hata Türleri - Run-Time(Çalışma Zamanı) Hataları
/*Syntax da bir problem yok ,kodun semantiği kusursuz , çalışma zamanında patlamaya sebeb veren hatalardır.
 *Yazılım ayaktayken ortaya çıkan bir takım aykırı durumlardan dolayı programın işletim sistemi tarafından kesilmesiyle/ sonlandırılmasıyla
 *durumudur.
 *Çalışma zamanı hataları programın işleyişinin ortasında direkt kullanıcıyla temas edebilecek hatalardır. 
 *Oynadığımız oyularda , programlarda karşımıza çıkabilecek bir hata türüdür.
 *Ve hiçbir yazılımcı son kullanıcının hatayla karşılaşmasını istemez . 
 *Genellikle kültürden kültüre boyutu değişsede bir hatayla karşılaşan son kullanıcı derinden kulak kaşındırabilir.(Ticari açıdanda sıkıntı yaratabilir)
 *Böyle bir durumda çalışma zamanında alınabilecek "olan hataları" yönetmek bir şekilde manipüle etmemiz gerekecektir.
 *Çalışma zamanı hataları genellikle kullanılan mimaride öntanımlı mesajları verecektir.
 *Eğer ki alınan hatanın mimaride bir karşılığı yoksa işletim sistemi dili kullanılacak ve daha kompleks bir açıklamayla karşılaşılacaktır.
 *Olması gereken ise çalışma zamanı hatalarının önceden tespit edilip programcı tarafından daha anlaşılabilir bir şekilde düzenlenmesidir.
 *Tabi bunun içinde çalışma zamanı hatalarının sağlam bir öngörüyle tespit çalışması yapılması gerekmektedir.
 *Çalışma zamanı hatalarını önceden kestirmek oldukça zor olabilmektedir. Bu hataları öngörebilmek genellikle testerların işidir.
 *Uygulama mümkün mertebe test edilerek çalışma zamanı hataları tespit edilmeli ve programcı tarafından tanımlanmalıdır. Tüm bunlara rağmen 
 *gözden kaçan durumlar olması oldukça normaldir.Dolayısıyla bir programın gelişimi sahadaki belli bir sürece bağlıdır. Bu süreçten toplanan
 *loglar ve son kullanıcı dönütleri değerlendirilerek çalışma zamanı hataları tespit edilip arındırılabilir. Tespit edilen çalışma 
 *zamanlarının manipilasyonunun oldukça önemli olduğunu söyledik . PEki bunu nasıl yapacağızın cevabı : Yazılımda ki  hata kontrol 
 *mekanizmalarını devreye sokarak . Hata kontrol mekanizmaları çalışma zamanı hatalarını kullanıcıya hissetttirmeden yakalayabilmek ve 
 *ilgili hatayı manüpile edebilmek için vardır.
 */



//Çalışma Zamanı/Run-Time Hata Durumları​na Örnek Verelim
/*Olmayan bir dosyayı açmaya yahut üzerine yazmaya,okutmaya vs çalışmak . 
 *Olmayan değer üzerinde işlem yapmaya çalışmak . Uygun olmayan formatlarda çalışmak. 
 *Veritabanı bağlantısının kopması. 
 */

Console.WriteLine("Lütfen birinci sayiyi giriniz :");
int sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayiyi giriniz :");
int sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Toplam : " + (sayi1 + sayi2));

//Yukarıda ki örnek çalışma zamanı hatasına yönelik bir örnek verilmiştir. Hatanın çıkma/ olma sebebi bazı girilen değerlerin int e dönüştürüle
//meyecek değerlere sebebiyet/ müsama / açık kapı bırakmasından dolayı örnek çalışma zamanı hatası türüne girecektir..