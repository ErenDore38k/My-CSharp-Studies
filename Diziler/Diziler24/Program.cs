//Array Sınıfı - CreateInstance Metodu İle Çok Boyutlu Dizi Tanımlama

Array dizi = Array.CreateInstance(typeof(int), 5, 5);
Console.WriteLine(dizi.Rank);

//Yukarıdaki örmekteki dizi 2 boyutlu bir dizidir.