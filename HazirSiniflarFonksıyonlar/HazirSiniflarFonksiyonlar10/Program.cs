//DateTime - Compare Fonksiyonu

//Yazılım süreçlerinde iki tarihsel değer arasında karşılaştırma yapmak isteyebiliriz.Compare fonksiyonu verdiğimiz 2 tarihsel
//değeri karşılaştırarak integer bir değer döndürür.
//Fonksiyonumuz bizlere -1, 0 ve 1 değerlerini döndürür. -1, ilk 
//değer ikincisiden küçüktür, 0 durumunda eşittir. 1 değerinde ise ilk değer büyüktür şeklindedir.


DateTime Tarih1 = new DateTime(2023, 10, 25);
DateTime Tarih2 = new DateTime(2024, 10, 26);
int Result = DateTime.Compare(Tarih1, Tarih2);
if (Result < 0)
{
    Console.WriteLine($"{Tarih1} Küçüktür {Tarih2}.");
}
else if (Result == 0)
{
    Console.WriteLine($"{Tarih1} Esittir {Tarih2}.");
}
else if (Result == 1)
{
    Console.WriteLine($"{Tarih1} Büyüktür {Tarih2}.");
}