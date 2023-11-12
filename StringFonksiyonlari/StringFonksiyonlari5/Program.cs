//String Değeri + Operatörü İle Formatlandırma

string isim = "Eren", soyisim = "Döre", tcNo = "10259660054";
int yas = 20;
bool medenihal = false;
Console.WriteLine(" TC No: " + tcNo + " olan  " + isim + "  " + soyisim + " şahsın bilgileri | yas  : " + yas + " |   Medeni Hal : " + (medenihal ? " evli " : "Bekar"));

//+ ile string formatlandırmada ternary operatörü kullanılıyorsa bunu parantez içerisine almamız gerekmektedir.
//+ operatörü ile string formatlandırma operasyonu hem kod hem de performans açısından oldukça maliyetlidir.
//O yüzden tercih etmeyeceğiz. 