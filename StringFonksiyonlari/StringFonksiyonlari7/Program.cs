//String Değeri $(String Interpolation) Operatörü İle Formatlandırma

//String Interpolation string ifadenin içerisinde süslü parantez ile araya girerek programatik bir değişkenin değerini 
//bırakmamızı/ eklememizi sağlayan bir operatördür.
//Bir string değerin başına $ operatörü koyulursa bu ifadenin içerisinde String Interpolation operasyonunun/operatörünun 
//kullanılabilirliği sağlanır.Yani ilgili string içerisindeki {] süslü parantezler bir interpolation özelliği sergilerler.

string isim = "Eren", soyisim = "Döre", tcNo = "30259660088";
int yas = 20;
bool medenihal = false;

Console.WriteLine($" TC No : {tcNo} olan  {isim}  {soyisim} şahsın bilgileri | yas  : {yas} |   Medeni Hal : {(medenihal ? "evli" : "bekar")} ");


//String  Interpolation yapısal olarak arka planda string.Format fonksiyonuyla sekillenen bir operatördür.
//ternary vs kullanılıyorsa parantez içine alınız.
//String Interpolation kullanılan string ifadelerde metinsel olarak  {} süslü parantez kullanmak ihtiyacı durumunda operatif
//olan süslü parantezleri yine aynı operatörle ezerek metinsel hale getirebiliriz.