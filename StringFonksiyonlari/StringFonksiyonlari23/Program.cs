//String Fonksiyonları - Substring Metodu

//String fonksiyonlarından en önemlilerinden biri kesinlikle bilmen gerekli evrenseldir..
//Metinsel ifadenin belirli bir aralığını elde edip çalışmamızı sağlar.
//Girilen ilk sayı indeksi 2. sayı kaç tane getireceğimizi söyler.

string metin = "Şerefir seni sevmek şanlı galatasaray";
Console.WriteLine(metin.Substring(5));//5. İndeksten sonuna kadar tüm değerleri getir.
Console.WriteLine(metin.Substring(3, 18)); // 3. İndeksten sonra 18 tane değer getir.