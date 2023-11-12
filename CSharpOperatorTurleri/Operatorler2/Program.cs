
//İki farklı türde sayısal değer üzerinde yapılan aritmetik işle neticesinde sonuç büüyk olan türde dönecektir. 
int a1 = 10;
double a2 = 15;
double sonuc = a1 + a2;
//Aritmetik operatörler de küçük olan tür büyük olan türe bilinçsiz bir şekilde dönüştürülerek o şekilde yapılır. 
//O yüzden sonuç büyük olan türde elde edilecektir edilmektedir. 
//Bir istisnamız var...


// İstisna örneğimiz byte - byte üzerine ....
byte t1 = 85;
byte t2 = 33;
int Sonuc = t1 - t2;
Console.WriteLine(sonuc);

//Normalde iki sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç aynı türden dönecek iken 
//Bu iki değer byte ise bir istisna var o istisnada sonuç her daim int dönecektir. Böyle kabul edilmiştir. 
//Bir yazılımcı matematiksel işlem sırasına dikat etmelidir.Tüm matematik kuralları c# da geçerlidir. 




