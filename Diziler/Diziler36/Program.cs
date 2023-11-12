//Çok Boyutlu Dizilerin Belirli Bir Derecesinin Eleman Sayısını Hesaplama

int[,,] sayilar = new int[2, 2, 4];
sayilar[0, 0, 0] = 10;
sayilar[0, 0, 1] = 11;
sayilar[0, 0, 2] = 12;
sayilar[0, 0, 3] = 25;
sayilar[0, 1, 0] = 26;
sayilar[0, 1, 1] = 27;
sayilar[0, 1, 2] = 28;
sayilar[0, 1, 3] = 29;
sayilar[1, 0, 0] = 58;
sayilar[1, 0, 1] = 30;
sayilar[1, 0, 2] = 31;
sayilar[1, 0, 3] = 32;
sayilar[1, 1, 0] = 98;
sayilar[1, 1, 1] = 69;
sayilar[1, 1, 2] = 35;
sayilar[1, 1, 3] = 88;

Console.WriteLine(sayilar.GetLength(0));
Console.WriteLine(sayilar.GetLength(1));
Console.WriteLine(sayilar.GetLength(2));