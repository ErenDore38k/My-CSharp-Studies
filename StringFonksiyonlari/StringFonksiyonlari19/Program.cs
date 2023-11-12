//String Fonksiyonları - Insert Metodu

//Elimizdeki metinsel ifadeye bir değer dahil etmemizi/eklememizi sağlayan bir fonksiyondur.
//İlgili ekleme operasyonu gerçekleştikten sonra eklenmiş hali string olarak döndürülecektir.
//Metin orijinal verisi ayrı bir şekilde tutulacaktır yani dönen eklenmiş veri ile var olan veri arasında fark vardır.

string metin = "Şereftir seni sevmek şanlı";
Console.WriteLine(metin.Insert(26, " Galatasaray"));