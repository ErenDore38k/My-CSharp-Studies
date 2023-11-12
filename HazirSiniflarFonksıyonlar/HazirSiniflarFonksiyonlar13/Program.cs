//Random Sınıfı - Next Fonksiyonu

//Random'ı kullanabilmek için önceki yapılar içinde de yaptığımız gibi nesne oluşturmamız gerekecektir.OOP de derinlemesine 
//öğreneceğimiz işlemdir bunlar.Algoritmada rastgele sayı üretmek gibi işlemlerde kullanabilmekteyiz.Random sınıfının dışında 
//farklı mimarilerde de bu tarz sınıflar vardır.Lkain genellikle Rondom sınıfı kulanılmaktadır.


Random random = new Random();
Console.WriteLine(random.Next());// 0 ile integer'ın değer aralığında rast gele bir değer 
Console.WriteLine(random.Next(100)); // 0 ile 100 arasında bir değer 
Console.WriteLine(random.Next(20, 100)); // 20 ile 100 arasında bir değer