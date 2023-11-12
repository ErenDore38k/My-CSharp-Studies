
//Karşılaştırma operatörleri 
//Karşılaştırma operatörleri geriye her daim bool türde bir değer dömdürecektir.


//Mantıksal operatörler ve bilgiler...
//&& ve operatörüdür. Ve Operatörü tüm şartlarının yani isteklerinin gerçekleşmesini ister .
//Eğer ki isteklerinden biri bile yanlış yani false olması durumunda yanlış yani false 0 değerini verir.
//veya || veya operatörüdür. Veya operatörü şartlardan en az bir tanesinin yerinne getirilmiş olması yeterlidir. 
//illaki de ikisi yerinde olsun diye bir şart yok . Yanlış yani false , değerini verdiği tek bir şart var o da 
//iki durumun da yerine getirilememe durumunda false 0 değerini verir. 
// ^ yada operatörüdür. Yada operatörü şartlardan kesinlikle bir tanesinin yerine getirilmesini ister.


// Mantıksal operatörler mantıksal değerler üzerinde kullanılır. 
bool patates = true, kofte = false;
bool sonuc1 = patates && kofte;
bool sonuc2 = patates || kofte;
bool sonuc3 = patates ^ kofte;
Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);
Console.WriteLine(sonuc3);
// Mantıksal operatörler geriye bool/ mantıksal sonuç dönerler.... 


