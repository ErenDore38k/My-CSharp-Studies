//String Değeri string.Format Metodu İle Formatlandırma

//String format fonksiyonu metinsel kalıbın içerisindeki indexel belirlenen noktalara sırayla değer göndermemizi sağlayan bir
//fonksiyondur.

string isim = "Eren", soyisim = "Döre", tcNo = "20259660058";
int yas = 20;
bool medenihal = false;

string sonuc = string.Format(" TC No : {0} olan  {1}  {2} şahsın bilgileri | yas  : {3} |   Medeni Hal : {4}", tcNo, isim, soyisim, yas, medenihal ? "evli" : "bekar");
Console.WriteLine(sonuc);