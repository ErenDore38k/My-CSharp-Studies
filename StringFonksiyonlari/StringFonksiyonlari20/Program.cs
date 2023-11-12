//String Fonksiyonları - Remove Metodu

//En önemli metodlardan biridir.
//Metinsel ifadede indeksel olarak verilen değer aralığını silen bir fonksiyondur.

string metin = "TürkiyeÜlkedir";
Console.WriteLine(metin.Remove(5));// Bu 5.indexten sonraki tüm değerleri sil anlamına gelir.
Console.WriteLine(metin.Remove(3, 6)); // Bu 3. indexten başla 6 adet sil anlamına gelir.
Console.WriteLine(metin.Remove(4, 7));

//Insert’te olduğu gibi ilgili fonksiyonun yapmış olduğu işlem neticesinde yeni değeri üreterek string olarak döndürecektir. 
//Elimizdeki orijinal ifade değişmeyecektir.