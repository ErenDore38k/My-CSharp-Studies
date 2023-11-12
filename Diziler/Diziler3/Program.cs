//Tanımlanmış Diziden Değer Okuma

//Dizilerde değer okurken değer aralığının aşılmamasına dikkat edilmesi gerekmektedir.

int[] yaslar = new int[7];
yaslar[3] = 30;
yaslar[2] = 36;
yaslar[0] = 41;
yaslar[5] = 58;
Console.WriteLine(yaslar[3]);
Console.WriteLine(yaslar[6]);

//Console.WriteLine(yaslar[7]); Eğer yandaki gibi dizinin olmayan 7.indeksini okumaya/yazdırmaya çalışısırsak hata alırız(çalışma 
//zamanı hatası).