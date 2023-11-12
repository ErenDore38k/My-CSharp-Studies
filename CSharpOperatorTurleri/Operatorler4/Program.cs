
// Arttırma(++) Azaltma(--) Operatörleri
// ++ atrı operatörüdür sayıyı +1 arttırır. -- azaltma operatörüdür sayıyı 1 azaltır .
int v = 5;
v++;
Console.WriteLine(v);

//Yukarıda ki örnekteki gibi yapabiliriz .Yukarıda örnekte Compiler v değişkenini v = v+1 şeklinde algılar ve 
//ona göre yazdırma işlemi gerçekleşir.
//++i : öncelikle i değerini 1  arttırır sonra i değeri döndürülür. 
//i++ : öncelikle i değerini döndürür sonra 1 arttırır. 
//Bu tarz farklara dikkat edilmesi gerekmektedir. 


/* Arttırma azaltma operatörlerinde biz sayıyı 1 arttırıyorduk ama velakin birden daha fazla arttırmak istediğimizde ise 
 * üzerine ekleme yığma operatörlerine başvuracağız. Kullanım şekli ise ...
 * ilk olarak i = i+5; şeklinde yapabiliriz bir diğer yol ise 
 * i+= 5; şeklinde gerçekleştirebiliriz. 
 * Biz yazılımcılar cimri insanlarız fazladan yere kod yazmayı sevmeyiz gıcık oluruz. 
 * Bu operatörleri de daha hızlı daha pratik işlem yapmak için kullanırız. 
 */