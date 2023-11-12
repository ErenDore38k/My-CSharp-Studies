//Random Sınıfı - NextDouble Fonksiyonu

//Ondalıklı olarak 0 ile 1 arasında rastgele bir değer oluşturmak istersekte 

Random random = new Random();
Console.WriteLine(random.NextDouble()); // bu şekilde kullanım yaparız.


//Herhangi bir overload’ı yoktur ve parametre almamaktadır.
//Next fonksiyonu ile integer bir değer dönerken haliyle NextDouble fonkisyonu ile double bir değer dönecektir
/*
while (true)
{
    Console.WriteLine(random.NextDouble()); // bu şekilde ile sonsuz döngü ile kullanımda yapabiliriz.

}
*/