//Array Sınıfı IsFixedSize Propertysi

//Bir veri kümesinin eleman sayısının sabit olup olmama durumunu IsFixedSize ile öğrenebiliriz.
//Tüm dizilerde eleman sayısı sabit olduğu için sürekli true dönecektir.Örneğin ArrayList koleksiyonunda false dönmektedir.

Array names = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
Console.WriteLine(names.IsFixedSize);