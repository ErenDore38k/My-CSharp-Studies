//String Fonksiyonları - IndexOf Metodu

//Verilen değerin string ifade içerisinde olup olmamasını integer olarak aranan ifadenin başlangıç index numarasını döndüren bir 
//fonksiyondur. İfade yoksa -1 değerinin döndürür.
//İndexof ilk eşleşen değerin indexini döndürür.

string metin = "Kaydığımızköykadıköy";
Console.WriteLine(metin.IndexOf("köy"));
Console.WriteLine(metin.IndexOf("y"));
Console.WriteLine(metin.IndexOf("ka"));
Console.WriteLine(metin.IndexOf("T"));