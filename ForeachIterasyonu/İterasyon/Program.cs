//İterasyon Nedir?

/*
 *Mantıksal açıdan her tahminin altında bir iterasyon mantığı yatar. Örneğin bizlere 1,3,5 diye birkaç değer verildiğinde
 *devamı 7,9,11 diye itere ederek düşünebilmekteyiz.Dil bilimi olarak ta örneğin, tekrar eden hecelerden oluşuyorsa, bu iterasyonel
 *bir kelime hatta cümlenin içerisinde tekrar eden kelimeler varsa da iterasyonel cümlede denmektedir. Bilgisayar biliminde ise
 *veri kaynaklarımız vardır ve bu kaynakları öğrendiğimiz diziler ya da koleksiyonlarda tutmaktayız.Bunun gibi  veri türlerinde
 *işlem yaparken iterasyon mantığı kullanılabilmektedir. 
 */




//İterasyon ile Döngü Arasındaki Fark Nedir?

int[] sayilar = { 3, 6, 32, 35, 37, 15, 88 };  // Diziler üzerinden örnek bir dizi 
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}

//Elimizdeki veri kümeleri üzerinde itere ederek işlem yapmamızı sağlayan mantıktır esasen.Ve bu iterasyonda elimizdeki kümenin 
//içerisindeki tüm değerlerle çalışırız,ilk veriden son veriye kadar itere edilerek çalışma prensibi olacaktır ve döngülerdeki
//algoritmik olarak sürece kadar karar veremeyiz.
//Foreach(iterasyon) bir döngü değildir!!!!!! Foreach ile elimizde bir verisel küme olmadan işlem yapamayız ancak döngüler
//bildiğimiz gibi mantıksal kombinasyonlar ile çalışan birer yapılardır.Bu yüzden bu iki yapı türü operasyonel olarak 
// birbirlerine benzeselerde FARKLIDIRLAR.
