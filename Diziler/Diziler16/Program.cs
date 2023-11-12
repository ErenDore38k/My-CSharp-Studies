//Array Sınıfı IndexOf Metodu

//Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur.
//Arama neticesinde ilgili değer varsa int olarak o değerin index numarasını döndürecektir. Yoksa -1 değerini döndürür. 

Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
int index = Array.IndexOf(isimler, "Rıfkı");
if (index != -1)
{
    Console.WriteLine("Aradığın değer mevcut dizide bulunmaktadır.");
}

//İndexof metodunu sıklıkla kullanırız.
