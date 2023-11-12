//Düzensiz Diziler - Eleman Sayısını Öğrenme

int[][] sayilar = new int[3][];
sayilar[0] = new int[3] { 2, 4, 6 };
sayilar[1] = new int[5] { 3, 6, 9, 12, 15 };
sayilar[2] = new int[2] { 36, 38 };
Console.WriteLine(sayilar[0][0]);
Console.WriteLine(sayilar[2][1]);

//Console.WriteLine(sayilar.Length); Düzensiz dizinin eleman sayısını getirir. Bu bize total eleman sayısını vermez . Çok
//boyutlu dizilerde olduğu gibi düzensiz diziler başlı başına farklı bir dizi yapısı değildir.Normal dizi yapılanmasıdır.
//Lakin içerisinde dizi barındıran bir dizidir.Haliyle eleman sayısını döndürür.İçteki dizilerin eleman sayılarını totalde
//elde edebilmek için herbirini toplamamız gerekmektedir. 
//Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length);